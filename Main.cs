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
using System.Net.Sockets;

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {
        //Intial connect Camera
        public CogToolBlock toolBlock = new CogToolBlock();
        CogFrameGrabbers myframegrabbers;
        ICogFrameGrabber myframegrabber;
        ICogAcqFifo myFifo;

        //Intial connect PLC 
        private TcpClient tcpClient_PLC = new TcpClient();
        private string IpAddress_PLC;
        private int Port_PLC;
        Stream stream_PLC = null;

        //Intial connect Lights
        private TcpClient tcpClient_Lights = new TcpClient();
        private string IpAddress_Lights;
        private int Port_Lights;
        Stream stream_Lights = null;


        public Main()
        {
            InitializeComponent();
        }

        private void tsSetupCamera_Menu1_Click(object sender, System.EventArgs e)
        {
            Setup_Camera setup_Camera = new Setup_Camera();
            setup_Camera.ShowDialog();
        }

        private void tsSetupPLC_Menu1_Click(object sender, System.EventArgs e)
        {
            Connect_PLC connect_PLC = new Connect_PLC();
            connect_PLC.ShowDialog();

        }
    }

}
