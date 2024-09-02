using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void setupCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup_Camera setup_Camera = new Setup_Camera();
            setup_Camera.Show();
        }
    }


}
