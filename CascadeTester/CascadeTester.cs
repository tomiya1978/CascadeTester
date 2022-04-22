using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.WpfExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Size = OpenCvSharp.Size;

/// <summary>
/// Author:SASAKI, Tomiya
/// 
/// </summary>
namespace CascadeTester
{
    public partial class CascadeTester : Form
    {
        // 画像を描画する場所
        Bitmap canvas = null;

        // 選択されたラジオボタンの値、分類器の種類
        String callKey = "";

        // 分類器ファイル名
        String CLASSIFIER_FILE_PATH = "";

        // バージョン番号 from app.config
        String VersionNo = "";

        // 自作分類器を示す変数 
        readonly String ORIGINAL = "ORIGINAL";

        public CascadeTester()
        {
            InitializeComponent();

            pictureBox1.AllowDrop = true;

            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            // バージョン番号読み込み
            VersionNo = ConfigurationManager.AppSettings["VERSION"];

            this.Text = this.Text +"   "+ VersionNo;

        }// public CascadeTester

        /// <summary>
        /// D&Dで投入された画像ファイルを画面に表示する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            StringBuilder sbErr = new StringBuilder();
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop);

            // ファイルの存在確認
            if(File .Exists(fileName[0]) == false)
            {
                sbErr.AppendLine(((sbErr.Length != 0) ? "\n" : "") + "ファイルが存在しません。");
            }//if

            // ファイルの読み込み可能かの確認
            if(IsFileLocked(fileName[0]) == true)
            {
                sbErr.AppendLine( ((sbErr.Length != 0) ? "\n" : "") + "ファイル読み込むことができません。");
            }//if

            // 画像のフォーマット確認
            if(IsReadableImage(fileName[0])== false)
            {
                sbErr.AppendLine(((sbErr.Length != 0) ? "\n" : "") + "読み込み可能な画像形式ではありません。");
            }

            if(sbErr.Length != 0)
            {
                MessageBox.Show(sbErr.ToString(),"エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            // 複数の場合、1個目の画像を表示
            try
            {
                pictureBox1.ImageLocation = fileName[0];
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            
        }//private void PictureBox1_DragDrop

        /// <summary>
        /// 読み込み可能な画像形式を判定する。
        /// 現在：jpg, bmp,  gif,png
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private bool IsReadableImage(string path)
        {
            bool rtnValue = false;
            Image img = Image.FromFile(path);

            //イメージのファイル形式を調べる

            // BMP
            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
            {
                rtnValue = true;
            }
            else if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
            {
                // GIF
                rtnValue = true;
            }
            else if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
            {
                //JPEG
                rtnValue = true;
            }
            else if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
            {
                // PNG
                rtnValue = true;
            }
            else if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.MemoryBmp))
            {
                // BMP
                rtnValue = true;
            }//else

            return rtnValue;
        }//private bool IsReadableImage

        /// <summary>
        /// 指定されたファイルがロックされているかどうかを返します。
        /// </summary>
        /// <param name="path">検証したいファイルへのフルパス</param>
        /// <returns>ロックされているかどうか true:ロックされている false:ロックされていない</returns>
        private bool IsFileLocked(string path)
        {
            FileStream stream = null;

            try
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch
            {
                return true;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Close();
                }
            }// finally

            return false;
        }//private bool IsFileLocked

        /// <summary>
        /// D&Dで受け入れる操作の指定。
        /// ファイルだけ受け入れる。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) == true)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }//else

        }//private void PictureBox1_DragEnter

        /// <summary>
        /// 検出開始
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            // ラジオボタンの選択
            String keyName = "";

            // 画像が読み込まれているかの確認
            if (canvas == null)
            {
                MessageBox.Show("画像が読み込まれていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//if

            // ラジオボタンの選択
            keyName = ConfigurationManager.AppSettings[callKey];

            // ORIGINAL なら、そのままファイル指定する
            if (callKey == ORIGINAL)
            {
                CLASSIFIER_FILE_PATH = this.TbCascadeFile.Text;
            }
            else if (callKey.StartsWith("lbp_") == true)
            {
                CLASSIFIER_FILE_PATH = System.Environment.CurrentDirectory
                + @"\" + ConfigurationManager.AppSettings["lbp_dir"]
                + @"\" + keyName;
            }
            else
            {
                // それ以外なら指定されたPathとファイル名を組み合わせて指定する。
                CLASSIFIER_FILE_PATH = System.Environment.CurrentDirectory 
                    +@"\"+ConfigurationManager.AppSettings["harr_dir"] 
                    + @"\" + keyName;
            }//else

            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(ConfigurationManager.AppSettings["harr_dir"]);

            canvas = new Bitmap(pictureBox1.Image);
  
            // 読み込んだ画像ファイルをMat形式に変換して画像認識の準備を行う
            Mat MatImg = BitmapConverter.ToMat(canvas);

            var haarCascade = new CascadeClassifier(CLASSIFIER_FILE_PATH);

            var faces = haarCascade.DetectMultiScale(
                    image: MatImg,
                    scaleFactor: 1.1,
                    minNeighbors: 3,
//                    flags: HaarDetectionType.ScaleImage,
                    minSize: new Size(100, 100));

            int count = 0;
            Console.WriteLine(faces.Count());
            if(faces.Count() == 0)
            {
                MessageBox.Show("認識できませんでした。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(var face in faces)
            {
                Cv2.Rectangle(
                    img: MatImg,
                    rect: new Rect(face.X,face.Y,face.Width,face.Height),
                    color: new Scalar(255,255,0),
                    thickness:5
                    );
                count++;
            }//foreach

            pictureBox1.Image = BitmapConverter.ToBitmap(MatImg);

        }//private void BtnStart_Click

        private void RbEye_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "eye";
        }//private void RbEye_CheckedChanged

        private void RbEyeTreeEyeglasses_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "eye tree eyeglasses";
        }//private void RbEyeTreeEyeglasses_CheckedChanged

        private void RbFrontalCatFace_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalcatface";
        }//private void RbFrontalCatFace_CheckedChanged

        private void RbFrontalCatFaceExtended_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalcatface extended";
        }//private void RbFrontalCatFaceExtended_CheckedChanged

        private void RbFrontalFaceAlt_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalface alt";
        }//private void RbFrontalFaceAlt_CheckedChanged

        private void RbFrontalFaceAltTree_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalface alt tree";
        }//private void RbFrontalFaceAltTree_CheckedChanged

        private void RbFrontalFaceAlt2_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalface alt2";
        }//private void RbFrontalFaceAlt2_CheckedChanged

        private void RbFrontalFaceDefault_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "frontalface default";
        }//private void RbFrontalFaceDefault_CheckedChanged

        private void RbFullBody_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "fullbody";
        }//private void RbFullBody_CheckedChanged

        private void RbLeftEye_2splits_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lefteye 2splits";
        }//private void RbLeftEye_2splits_CheckedChanged

        private void RbLicencePlateRus16stages_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "licence plate rus 16stages";
        }//private void RbLicencePlateRus16stages_CheckedChanged

        private void RbLowerbody_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lowerbody";
        }//private void RbLowerbody_CheckedChanged

        private void RbProfileFace_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "profileface";
        }//private void RbProfileFace_CheckedChanged

        private void RbRightEye2splits_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "righteye 2splits";
        }//private void RbRightEye2splits_CheckedChanged

        private void RbRussianPlateNumber_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "russian plate number";
        }//private void RbRussianPlateNumber_CheckedChanged

        private void RbSmile_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "smile";
        }//private void RbSmile_CheckedChanged

        private void RbUpperBody_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_upperbody";
        }//private void RbUpperBody_CheckedChanged

        private void Rb_lbp_frontalCatFace_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_frontalcatface";
        }//private void Rb_lbp_frontalCatFace_CheckedChanged

        private void Rb_LBP_SilverWare_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_silverware";
        }//private void Rb_LBP_SilverWare_CheckedChanged

        private void Rb_LBP_Frontal_Face_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_frontalface";
        }//private void Rb_LBP_Frontal_Face_CheckedChanged

        private void Rb_LBP_Frontal_Face_Improved_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_frontalface_improved";
        }//private void Rb_LBP_Frontal_Face_Improved_CheckedChanged

        private void Rb_LBP_Profile_Face_CheckedChanged(object sender, EventArgs e)
        {
            callKey = "lbp_profileface";
        }//private void Rb_LBP_Profile_Face_CheckedChanged

        private void RbOriginal_CheckedChanged(object sender, EventArgs e)
        {
            callKey = ORIGINAL;
            // ファイル名取得
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // カスケードファイルのフルパスをテキストボックスに格納する
                this.TbCascadeFile.Text = ofd.FileName;
            }//if

        }//private void RbOriginal_CheckedChanged

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe(VersionNo);
            am.ShowDialog();
        }
    }//public partial class Form1 : Form
}
