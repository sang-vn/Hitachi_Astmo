using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_Astemo
{
    public partial class ToolBlockEdit : Form
    {
        public CogToolBlock toolBlock3 = new CogToolBlock();
        public ToolBlockEdit()
        {
            InitializeComponent();
        }

        private void ToolBlockEdit_Load(object sender, EventArgs e)
        {
            string Path1 = Path.Combine(Environment.CurrentDirectory, "VPro Program", "Cam_1.vpp");
            toolBlock3 = CogSerializer.LoadObjectFromFile(Path1) as CogToolBlock;
            cogToolBlockEditV21.Subject = toolBlock3;
        }
    }
}
