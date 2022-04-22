using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CascadeTester
{
    public partial class AboutMe : Form
    {
        public AboutMe(string version)
        {
            InitializeComponent();
            Lbl_Version.Text = version;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
