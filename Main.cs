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
        public string IpAddress_PLC = "192.168.1.100";
        public int Port_PLC = 3000;
        private Stream stream_PLC = null;

        //Intial connect Lights
        private TcpClient tcpClient_Lights = new TcpClient();
        public string IpAddress_Lights = "192.168.1.10";
        public int Port_Lights = 2000;
        private Stream stream_Lights = null;


        public Main()
        {
            InitializeComponent();
        }

        private void tsSetupCamera_Menu1_Click(object sender, System.EventArgs e)
        {
            Setup_Camera setup_Camera = new Setup_Camera();
            setup_Camera.ShowDialog();
        }


        //Setup PLC
        private void tsSetupPLC_Menu1_Click(object sender, System.EventArgs e)
        {
            Connect_PLC connect_PLC = new Connect_PLC();
            connect_PLC.tbIpAddress.Text = "192.168.1.100";
            connect_PLC.tbPort.Text = "3000";
            connect_PLC.IPChanged += PlC_IP_Changed;
            connect_PLC.ShowDialog();
        }
        public string IpAddress { get; set; }
        public int Port { get; set; }
        private void PlC_IP_Changed(object sender, Tuple<string, int> inPort)
        {
            this.IpAddress = inPort.Item1;
            this.Port = inPort.Item2;

            //Cập nhật giao diện
            IpAddress_PLC = inPort.Item1;
            Port_PLC = inPort.Item2;


        }

        //Setup Camera


        //Setup Lights
    }

}
