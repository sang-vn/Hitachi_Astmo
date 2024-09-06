using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cognex.Vision;
using Cognex.VisionPro.ToolBlock;
using System.IO;
using Cognex.VisionPro;
using System.Security.Cryptography;

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {
        public CogToolBlock toolBlock1 = new CogToolBlock();
        public CogToolBlock toolBlock2 = new CogToolBlock();

        public Main()
        {
            InitializeComponent();
        }

        private void setupCameraToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Setup_Camera setup_Camera = new Setup_Camera();
            setup_Camera.Show();
        }

        private void connectPLCToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Connect_PLC connect_PLC = new Connect_PLC();
            connect_PLC.Show();
        }

        private void setupProgramsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            string Path1 = Path.Combine(Environment.CurrentDirectory, "VPro Program", "Cam_1.vpp");
            toolBlock1 = CogSerializer.LoadObjectFromFile(Path1) as CogToolBlock;

            string Path2 = Path.Combine(Environment.CurrentDirectory, "VPro Program", "Cam_2.vpp");
            toolBlock2 = CogSerializer.LoadObjectFromFile(Path2) as CogToolBlock;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            toolBlock1.Run();
            cogRecordDisplay1.InteractiveGraphics.Clear();
            cogRecordDisplay1.StaticGraphics.Clear();
            cogRecordDisplay1.Record = toolBlock1.CreateLastRunRecord().SubRecords[0];
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            toolBlock2.Run();
            cogRecordDisplay2.InteractiveGraphics.Clear();
            cogRecordDisplay2.StaticGraphics.Clear();
            cogRecordDisplay2.Record = toolBlock1.CreateLastRunRecord().SubRecords[0];
        }

        private void toolBlockEditToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ToolBlockEdit toolBlockEdit = new ToolBlockEdit();
            toolBlockEdit.Show();
        }
    }

}
