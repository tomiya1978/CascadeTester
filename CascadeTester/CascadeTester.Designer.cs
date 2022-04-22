namespace CascadeTester
{
    partial class CascadeTester
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rbEye = new System.Windows.Forms.RadioButton();
            this.rbEyeTreeEyeglasses = new System.Windows.Forms.RadioButton();
            this.rbFrontalCatFace = new System.Windows.Forms.RadioButton();
            this.rbFrontalCatFaceExtended = new System.Windows.Forms.RadioButton();
            this.rbFrontalFaceAlt = new System.Windows.Forms.RadioButton();
            this.rbFrontalFaceAltTree = new System.Windows.Forms.RadioButton();
            this.gb_Haar = new System.Windows.Forms.GroupBox();
            this.rb_LBP_SilverWare = new System.Windows.Forms.RadioButton();
            this.rb_LBP_Profile_Face = new System.Windows.Forms.RadioButton();
            this.rb_LBP_Frontal_Face_Improved = new System.Windows.Forms.RadioButton();
            this.rb_lbp_frontalCatFace = new System.Windows.Forms.RadioButton();
            this.rb_LBP_Frontal_Face = new System.Windows.Forms.RadioButton();
            this.rbUpperBody = new System.Windows.Forms.RadioButton();
            this.rbSmile = new System.Windows.Forms.RadioButton();
            this.rbRussianPlateNumber = new System.Windows.Forms.RadioButton();
            this.rbRightEye2splits = new System.Windows.Forms.RadioButton();
            this.rbProfileFace = new System.Windows.Forms.RadioButton();
            this.rbLicencePlateRus16stages = new System.Windows.Forms.RadioButton();
            this.rbLeftEye_2splits = new System.Windows.Forms.RadioButton();
            this.rbFullBody = new System.Windows.Forms.RadioButton();
            this.btnRef = new System.Windows.Forms.Button();
            this.TbCascadeFile = new System.Windows.Forms.TextBox();
            this.rbOriginal = new System.Windows.Forms.RadioButton();
            this.rbFrontalFaceAlt2 = new System.Windows.Forms.RadioButton();
            this.rbFrontalFaceDefault = new System.Windows.Forms.RadioButton();
            this.rbLowerbody = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_Haar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(784, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox1_DragEnter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rbEye
            // 
            this.rbEye.AutoSize = true;
            this.rbEye.Location = new System.Drawing.Point(6, 18);
            this.rbEye.Name = "rbEye";
            this.rbEye.Size = new System.Drawing.Size(42, 16);
            this.rbEye.TabIndex = 2;
            this.rbEye.TabStop = true;
            this.rbEye.Text = "Eye";
            this.rbEye.UseVisualStyleBackColor = true;
            this.rbEye.CheckedChanged += new System.EventHandler(this.RbEye_CheckedChanged);
            // 
            // rbEyeTreeEyeglasses
            // 
            this.rbEyeTreeEyeglasses.AutoSize = true;
            this.rbEyeTreeEyeglasses.Location = new System.Drawing.Point(6, 40);
            this.rbEyeTreeEyeglasses.Name = "rbEyeTreeEyeglasses";
            this.rbEyeTreeEyeglasses.Size = new System.Drawing.Size(131, 16);
            this.rbEyeTreeEyeglasses.TabIndex = 3;
            this.rbEyeTreeEyeglasses.TabStop = true;
            this.rbEyeTreeEyeglasses.Text = "Eye Tree Eyeglasses";
            this.rbEyeTreeEyeglasses.UseVisualStyleBackColor = true;
            this.rbEyeTreeEyeglasses.CheckedChanged += new System.EventHandler(this.RbEyeTreeEyeglasses_CheckedChanged);
            // 
            // rbFrontalCatFace
            // 
            this.rbFrontalCatFace.AutoSize = true;
            this.rbFrontalCatFace.Location = new System.Drawing.Point(6, 62);
            this.rbFrontalCatFace.Name = "rbFrontalCatFace";
            this.rbFrontalCatFace.Size = new System.Drawing.Size(110, 16);
            this.rbFrontalCatFace.TabIndex = 4;
            this.rbFrontalCatFace.TabStop = true;
            this.rbFrontalCatFace.Text = "Frontal Cat Face";
            this.rbFrontalCatFace.UseVisualStyleBackColor = true;
            this.rbFrontalCatFace.CheckedChanged += new System.EventHandler(this.RbFrontalCatFace_CheckedChanged);
            // 
            // rbFrontalCatFaceExtended
            // 
            this.rbFrontalCatFaceExtended.AutoSize = true;
            this.rbFrontalCatFaceExtended.Location = new System.Drawing.Point(6, 84);
            this.rbFrontalCatFaceExtended.Name = "rbFrontalCatFaceExtended";
            this.rbFrontalCatFaceExtended.Size = new System.Drawing.Size(161, 16);
            this.rbFrontalCatFaceExtended.TabIndex = 5;
            this.rbFrontalCatFaceExtended.TabStop = true;
            this.rbFrontalCatFaceExtended.Text = "Frontal Cat Face Extended";
            this.rbFrontalCatFaceExtended.UseVisualStyleBackColor = true;
            this.rbFrontalCatFaceExtended.CheckedChanged += new System.EventHandler(this.RbFrontalCatFaceExtended_CheckedChanged);
            // 
            // rbFrontalFaceAlt
            // 
            this.rbFrontalFaceAlt.AutoSize = true;
            this.rbFrontalFaceAlt.Location = new System.Drawing.Point(6, 106);
            this.rbFrontalFaceAlt.Name = "rbFrontalFaceAlt";
            this.rbFrontalFaceAlt.Size = new System.Drawing.Size(107, 16);
            this.rbFrontalFaceAlt.TabIndex = 6;
            this.rbFrontalFaceAlt.TabStop = true;
            this.rbFrontalFaceAlt.Text = "Frontal Face Alt";
            this.rbFrontalFaceAlt.UseVisualStyleBackColor = true;
            this.rbFrontalFaceAlt.CheckedChanged += new System.EventHandler(this.RbFrontalFaceAlt_CheckedChanged);
            // 
            // rbFrontalFaceAltTree
            // 
            this.rbFrontalFaceAltTree.AutoSize = true;
            this.rbFrontalFaceAltTree.Location = new System.Drawing.Point(187, 18);
            this.rbFrontalFaceAltTree.Name = "rbFrontalFaceAltTree";
            this.rbFrontalFaceAltTree.Size = new System.Drawing.Size(134, 16);
            this.rbFrontalFaceAltTree.TabIndex = 7;
            this.rbFrontalFaceAltTree.TabStop = true;
            this.rbFrontalFaceAltTree.Text = "Frontal Face Alt Tree";
            this.rbFrontalFaceAltTree.UseVisualStyleBackColor = true;
            this.rbFrontalFaceAltTree.CheckedChanged += new System.EventHandler(this.RbFrontalFaceAltTree_CheckedChanged);
            // 
            // gb_Haar
            // 
            this.gb_Haar.Controls.Add(this.rb_LBP_SilverWare);
            this.gb_Haar.Controls.Add(this.rb_LBP_Profile_Face);
            this.gb_Haar.Controls.Add(this.rb_LBP_Frontal_Face_Improved);
            this.gb_Haar.Controls.Add(this.rb_lbp_frontalCatFace);
            this.gb_Haar.Controls.Add(this.rb_LBP_Frontal_Face);
            this.gb_Haar.Controls.Add(this.rbUpperBody);
            this.gb_Haar.Controls.Add(this.rbSmile);
            this.gb_Haar.Controls.Add(this.rbRussianPlateNumber);
            this.gb_Haar.Controls.Add(this.rbRightEye2splits);
            this.gb_Haar.Controls.Add(this.rbProfileFace);
            this.gb_Haar.Controls.Add(this.rbLicencePlateRus16stages);
            this.gb_Haar.Controls.Add(this.rbLeftEye_2splits);
            this.gb_Haar.Controls.Add(this.rbFullBody);
            this.gb_Haar.Controls.Add(this.btnRef);
            this.gb_Haar.Controls.Add(this.TbCascadeFile);
            this.gb_Haar.Controls.Add(this.rbOriginal);
            this.gb_Haar.Controls.Add(this.rbFrontalFaceAlt2);
            this.gb_Haar.Controls.Add(this.rbFrontalFaceDefault);
            this.gb_Haar.Controls.Add(this.rbLowerbody);
            this.gb_Haar.Controls.Add(this.rbEye);
            this.gb_Haar.Controls.Add(this.rbFrontalFaceAltTree);
            this.gb_Haar.Controls.Add(this.rbEyeTreeEyeglasses);
            this.gb_Haar.Controls.Add(this.rbFrontalFaceAlt);
            this.gb_Haar.Controls.Add(this.rbFrontalCatFace);
            this.gb_Haar.Controls.Add(this.rbFrontalCatFaceExtended);
            this.gb_Haar.Location = new System.Drawing.Point(0, 391);
            this.gb_Haar.Name = "gb_Haar";
            this.gb_Haar.Size = new System.Drawing.Size(656, 232);
            this.gb_Haar.TabIndex = 8;
            this.gb_Haar.TabStop = false;
            this.gb_Haar.Text = "Select Cascade";
            // 
            // rb_LBP_SilverWare
            // 
            this.rb_LBP_SilverWare.AutoSize = true;
            this.rb_LBP_SilverWare.Location = new System.Drawing.Point(6, 164);
            this.rb_LBP_SilverWare.Name = "rb_LBP_SilverWare";
            this.rb_LBP_SilverWare.Size = new System.Drawing.Size(106, 16);
            this.rb_LBP_SilverWare.TabIndex = 26;
            this.rb_LBP_SilverWare.TabStop = true;
            this.rb_LBP_SilverWare.Text = "LBP Silver_Ware";
            this.rb_LBP_SilverWare.UseVisualStyleBackColor = true;
            this.rb_LBP_SilverWare.CheckedChanged += new System.EventHandler(this.Rb_LBP_SilverWare_CheckedChanged);
            // 
            // rb_LBP_Profile_Face
            // 
            this.rb_LBP_Profile_Face.AutoSize = true;
            this.rb_LBP_Profile_Face.Location = new System.Drawing.Point(501, 142);
            this.rb_LBP_Profile_Face.Name = "rb_LBP_Profile_Face";
            this.rb_LBP_Profile_Face.Size = new System.Drawing.Size(110, 16);
            this.rb_LBP_Profile_Face.TabIndex = 25;
            this.rb_LBP_Profile_Face.TabStop = true;
            this.rb_LBP_Profile_Face.Text = "LBP Profile Face";
            this.rb_LBP_Profile_Face.UseVisualStyleBackColor = true;
            this.rb_LBP_Profile_Face.CheckedChanged += new System.EventHandler(this.Rb_LBP_Profile_Face_CheckedChanged);
            // 
            // rb_LBP_Frontal_Face_Improved
            // 
            this.rb_LBP_Frontal_Face_Improved.AutoSize = true;
            this.rb_LBP_Frontal_Face_Improved.Location = new System.Drawing.Point(329, 142);
            this.rb_LBP_Frontal_Face_Improved.Name = "rb_LBP_Frontal_Face_Improved";
            this.rb_LBP_Frontal_Face_Improved.Size = new System.Drawing.Size(163, 16);
            this.rb_LBP_Frontal_Face_Improved.TabIndex = 24;
            this.rb_LBP_Frontal_Face_Improved.TabStop = true;
            this.rb_LBP_Frontal_Face_Improved.Text = "LBP Frontal Face Improved";
            this.rb_LBP_Frontal_Face_Improved.UseVisualStyleBackColor = true;
            this.rb_LBP_Frontal_Face_Improved.CheckedChanged += new System.EventHandler(this.Rb_LBP_Frontal_Face_Improved_CheckedChanged);
            // 
            // rb_lbp_frontalCatFace
            // 
            this.rb_lbp_frontalCatFace.AutoSize = true;
            this.rb_lbp_frontalCatFace.Location = new System.Drawing.Point(6, 142);
            this.rb_lbp_frontalCatFace.Name = "rb_lbp_frontalCatFace";
            this.rb_lbp_frontalCatFace.Size = new System.Drawing.Size(135, 16);
            this.rb_lbp_frontalCatFace.TabIndex = 22;
            this.rb_lbp_frontalCatFace.TabStop = true;
            this.rb_lbp_frontalCatFace.Text = "LBP Frontal Cat Face";
            this.rb_lbp_frontalCatFace.UseVisualStyleBackColor = true;
            this.rb_lbp_frontalCatFace.CheckedChanged += new System.EventHandler(this.Rb_lbp_frontalCatFace_CheckedChanged);
            // 
            // rb_LBP_Frontal_Face
            // 
            this.rb_LBP_Frontal_Face.AutoSize = true;
            this.rb_LBP_Frontal_Face.Location = new System.Drawing.Point(187, 142);
            this.rb_LBP_Frontal_Face.Name = "rb_LBP_Frontal_Face";
            this.rb_LBP_Frontal_Face.Size = new System.Drawing.Size(113, 16);
            this.rb_LBP_Frontal_Face.TabIndex = 23;
            this.rb_LBP_Frontal_Face.TabStop = true;
            this.rb_LBP_Frontal_Face.Text = "LBP Frontal Face";
            this.rb_LBP_Frontal_Face.UseVisualStyleBackColor = true;
            this.rb_LBP_Frontal_Face.CheckedChanged += new System.EventHandler(this.Rb_LBP_Frontal_Face_CheckedChanged);
            // 
            // rbUpperBody
            // 
            this.rbUpperBody.AutoSize = true;
            this.rbUpperBody.Location = new System.Drawing.Point(501, 40);
            this.rbUpperBody.Name = "rbUpperBody";
            this.rbUpperBody.Size = new System.Drawing.Size(83, 16);
            this.rbUpperBody.TabIndex = 21;
            this.rbUpperBody.TabStop = true;
            this.rbUpperBody.Text = "Upper Body";
            this.rbUpperBody.UseVisualStyleBackColor = true;
            this.rbUpperBody.CheckedChanged += new System.EventHandler(this.RbUpperBody_CheckedChanged);
            // 
            // rbSmile
            // 
            this.rbSmile.AutoSize = true;
            this.rbSmile.Location = new System.Drawing.Point(501, 18);
            this.rbSmile.Name = "rbSmile";
            this.rbSmile.Size = new System.Drawing.Size(51, 16);
            this.rbSmile.TabIndex = 20;
            this.rbSmile.TabStop = true;
            this.rbSmile.Text = "Smile";
            this.rbSmile.UseVisualStyleBackColor = true;
            this.rbSmile.CheckedChanged += new System.EventHandler(this.RbSmile_CheckedChanged);
            // 
            // rbRussianPlateNumber
            // 
            this.rbRussianPlateNumber.AutoSize = true;
            this.rbRussianPlateNumber.Location = new System.Drawing.Point(329, 106);
            this.rbRussianPlateNumber.Name = "rbRussianPlateNumber";
            this.rbRussianPlateNumber.Size = new System.Drawing.Size(137, 16);
            this.rbRussianPlateNumber.TabIndex = 19;
            this.rbRussianPlateNumber.TabStop = true;
            this.rbRussianPlateNumber.Text = "Russian Plate Number";
            this.rbRussianPlateNumber.UseVisualStyleBackColor = true;
            this.rbRussianPlateNumber.CheckedChanged += new System.EventHandler(this.RbRussianPlateNumber_CheckedChanged);
            // 
            // rbRightEye2splits
            // 
            this.rbRightEye2splits.AutoSize = true;
            this.rbRightEye2splits.Location = new System.Drawing.Point(329, 84);
            this.rbRightEye2splits.Name = "rbRightEye2splits";
            this.rbRightEye2splits.Size = new System.Drawing.Size(111, 16);
            this.rbRightEye2splits.TabIndex = 18;
            this.rbRightEye2splits.TabStop = true;
            this.rbRightEye2splits.Text = "Right Eye 2splits";
            this.rbRightEye2splits.UseVisualStyleBackColor = true;
            this.rbRightEye2splits.CheckedChanged += new System.EventHandler(this.RbRightEye2splits_CheckedChanged);
            // 
            // rbProfileFace
            // 
            this.rbProfileFace.AutoSize = true;
            this.rbProfileFace.Location = new System.Drawing.Point(329, 62);
            this.rbProfileFace.Name = "rbProfileFace";
            this.rbProfileFace.Size = new System.Drawing.Size(85, 16);
            this.rbProfileFace.TabIndex = 17;
            this.rbProfileFace.TabStop = true;
            this.rbProfileFace.Text = "Profile Face";
            this.rbProfileFace.UseVisualStyleBackColor = true;
            this.rbProfileFace.CheckedChanged += new System.EventHandler(this.RbProfileFace_CheckedChanged);
            // 
            // rbLicencePlateRus16stages
            // 
            this.rbLicencePlateRus16stages.AutoSize = true;
            this.rbLicencePlateRus16stages.Location = new System.Drawing.Point(329, 18);
            this.rbLicencePlateRus16stages.Name = "rbLicencePlateRus16stages";
            this.rbLicencePlateRus16stages.Size = new System.Drawing.Size(166, 16);
            this.rbLicencePlateRus16stages.TabIndex = 16;
            this.rbLicencePlateRus16stages.TabStop = true;
            this.rbLicencePlateRus16stages.Text = "Licence Plate Rus 16stages";
            this.rbLicencePlateRus16stages.UseVisualStyleBackColor = true;
            this.rbLicencePlateRus16stages.CheckedChanged += new System.EventHandler(this.RbLicencePlateRus16stages_CheckedChanged);
            // 
            // rbLeftEye_2splits
            // 
            this.rbLeftEye_2splits.AutoSize = true;
            this.rbLeftEye_2splits.Location = new System.Drawing.Point(187, 106);
            this.rbLeftEye_2splits.Name = "rbLeftEye_2splits";
            this.rbLeftEye_2splits.Size = new System.Drawing.Size(104, 16);
            this.rbLeftEye_2splits.TabIndex = 15;
            this.rbLeftEye_2splits.TabStop = true;
            this.rbLeftEye_2splits.Text = "Left Eye 2splits";
            this.rbLeftEye_2splits.UseVisualStyleBackColor = true;
            this.rbLeftEye_2splits.CheckedChanged += new System.EventHandler(this.RbLeftEye_2splits_CheckedChanged);
            // 
            // rbFullBody
            // 
            this.rbFullBody.AutoSize = true;
            this.rbFullBody.Location = new System.Drawing.Point(187, 84);
            this.rbFullBody.Name = "rbFullBody";
            this.rbFullBody.Size = new System.Drawing.Size(72, 16);
            this.rbFullBody.TabIndex = 14;
            this.rbFullBody.TabStop = true;
            this.rbFullBody.Text = "Full Body";
            this.rbFullBody.UseVisualStyleBackColor = true;
            this.rbFullBody.CheckedChanged += new System.EventHandler(this.RbFullBody_CheckedChanged);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(376, 205);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(75, 23);
            this.btnRef.TabIndex = 13;
            this.btnRef.Text = "Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            // 
            // TbCascadeFile
            // 
            this.TbCascadeFile.Location = new System.Drawing.Point(122, 207);
            this.TbCascadeFile.Name = "TbCascadeFile";
            this.TbCascadeFile.Size = new System.Drawing.Size(248, 19);
            this.TbCascadeFile.TabIndex = 12;
            // 
            // rbOriginal
            // 
            this.rbOriginal.AutoSize = true;
            this.rbOriginal.Location = new System.Drawing.Point(6, 208);
            this.rbOriginal.Name = "rbOriginal";
            this.rbOriginal.Size = new System.Drawing.Size(110, 16);
            this.rbOriginal.TabIndex = 11;
            this.rbOriginal.TabStop = true;
            this.rbOriginal.Text = "Original Cascade";
            this.rbOriginal.UseVisualStyleBackColor = true;
            this.rbOriginal.CheckedChanged += new System.EventHandler(this.RbOriginal_CheckedChanged);
            // 
            // rbFrontalFaceAlt2
            // 
            this.rbFrontalFaceAlt2.AutoSize = true;
            this.rbFrontalFaceAlt2.Location = new System.Drawing.Point(187, 40);
            this.rbFrontalFaceAlt2.Name = "rbFrontalFaceAlt2";
            this.rbFrontalFaceAlt2.Size = new System.Drawing.Size(113, 16);
            this.rbFrontalFaceAlt2.TabIndex = 10;
            this.rbFrontalFaceAlt2.TabStop = true;
            this.rbFrontalFaceAlt2.Text = "Frontal Face Alt2";
            this.rbFrontalFaceAlt2.UseVisualStyleBackColor = true;
            this.rbFrontalFaceAlt2.CheckedChanged += new System.EventHandler(this.RbFrontalFaceAlt2_CheckedChanged);
            // 
            // rbFrontalFaceDefault
            // 
            this.rbFrontalFaceDefault.AutoSize = true;
            this.rbFrontalFaceDefault.Location = new System.Drawing.Point(187, 62);
            this.rbFrontalFaceDefault.Name = "rbFrontalFaceDefault";
            this.rbFrontalFaceDefault.Size = new System.Drawing.Size(129, 16);
            this.rbFrontalFaceDefault.TabIndex = 9;
            this.rbFrontalFaceDefault.TabStop = true;
            this.rbFrontalFaceDefault.Text = "Frontal Face Default";
            this.rbFrontalFaceDefault.UseVisualStyleBackColor = true;
            this.rbFrontalFaceDefault.CheckedChanged += new System.EventHandler(this.RbFrontalFaceDefault_CheckedChanged);
            // 
            // rbLowerbody
            // 
            this.rbLowerbody.AutoSize = true;
            this.rbLowerbody.Location = new System.Drawing.Point(329, 40);
            this.rbLowerbody.Name = "rbLowerbody";
            this.rbLowerbody.Size = new System.Drawing.Size(83, 16);
            this.rbLowerbody.TabIndex = 8;
            this.rbLowerbody.TabStop = true;
            this.rbLowerbody.Text = "Lower Body";
            this.rbLowerbody.UseVisualStyleBackColor = true;
            this.rbLowerbody.CheckedChanged += new System.EventHandler(this.RbLowerbody_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(662, 391);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 64);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(697, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aboutToolStripMenuItem.Text = "About....";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem1.Text = "About....";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // CascadeTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 661);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gb_Haar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CascadeTester";
            this.Text = "CascadeTester";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_Haar.ResumeLayout(false);
            this.gb_Haar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton rbEye;
        private System.Windows.Forms.RadioButton rbEyeTreeEyeglasses;
        private System.Windows.Forms.RadioButton rbFrontalCatFace;
        private System.Windows.Forms.RadioButton rbFrontalCatFaceExtended;
        private System.Windows.Forms.RadioButton rbFrontalFaceAlt;
        private System.Windows.Forms.RadioButton rbFrontalFaceAltTree;
        private System.Windows.Forms.GroupBox gb_Haar;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.TextBox TbCascadeFile;
        private System.Windows.Forms.RadioButton rbOriginal;
        private System.Windows.Forms.RadioButton rbFrontalFaceAlt2;
        private System.Windows.Forms.RadioButton rbFrontalFaceDefault;
        private System.Windows.Forms.RadioButton rbLowerbody;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rbLicencePlateRus16stages;
        private System.Windows.Forms.RadioButton rbLeftEye_2splits;
        private System.Windows.Forms.RadioButton rbFullBody;
        private System.Windows.Forms.RadioButton rbRightEye2splits;
        private System.Windows.Forms.RadioButton rbProfileFace;
        private System.Windows.Forms.RadioButton rbUpperBody;
        private System.Windows.Forms.RadioButton rbSmile;
        private System.Windows.Forms.RadioButton rbRussianPlateNumber;
        private System.Windows.Forms.RadioButton rb_LBP_SilverWare;
        private System.Windows.Forms.RadioButton rb_LBP_Profile_Face;
        private System.Windows.Forms.RadioButton rb_LBP_Frontal_Face_Improved;
        private System.Windows.Forms.RadioButton rb_lbp_frontalCatFace;
        private System.Windows.Forms.RadioButton rb_LBP_Frontal_Face;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

