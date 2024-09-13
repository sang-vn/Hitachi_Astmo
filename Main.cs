using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Cognex.Vision;
using Cognex.VisionPro.ToolBlock;
using System.IO;
using Cognex.VisionPro;
using System.Security.Cryptography;
using System.Net.Sockets;
using CSharp_OPTControllerAPI;
using System.Windows.Media.Media3D;
using System.Threading;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using System.Timers;
using HslCommunication;                                                                                                         

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {

        //Tool Block
        private CogToolBlock tbCamera;
        private CogToolBlock tbVisionTool;

        private string Path_tbCamera;
        private string Path_tbVisionTool;

        //Intial connect PLC 
        private TcpClient tcpClient_PLC = new TcpClient();
        internal string IpAddress_PLC = "192.168.1.100";
        internal int Port_PLC = 3000;
        private Stream stream = null;

        //Intial connect Lights
        public OPTControllerAPI Light = null;
        private TcpClient tcpClient_Lights = new TcpClient();
        private string IpAddress_Lights = "192.168.1.16";
        //public int Port_Lights = 3000;

        private string trigger_signal = "10";
        private int model;

        private System.Timers.Timer timerTrigger = new System.Timers.Timer();
        private System.Timers.Timer timerHeartBit = new System.Timers.Timer();

        int i = 0;


        public Main()
        {
            InitializeComponent();

            //Loop read trigger from PLC then run Job
            if (timerTrigger == null) timerTrigger = new System.Timers.Timer();
            timerTrigger.Enabled = false;
            timerTrigger.Interval = 5000;
            timerTrigger.AutoReset = true;
            timerTrigger.Elapsed += TimerTrigger_Elapsed;

            //Loop send HeartBit
            if (timerHeartBit == null) timerHeartBit = new System.Timers.Timer();
            timerHeartBit.Enabled = false;
            timerHeartBit.Interval = 50;
            timerHeartBit.AutoReset = true;
            timerHeartBit.Elapsed += TimerHearBit_Elapsed;

        }

        private void Main_Load(object sender, EventArgs e)
        {
            IntialPLC();
            IntialLights();
            IntialProgram();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Dispose Timer
            timerHeartBit.Stop();
            timerHeartBit.Dispose();
            timerTrigger.Stop();
            timerTrigger.Dispose();

            //Disconnect Lights
            long lRet = -1;
            lRet = Light.DestroyEthernetConnect();
            if (lRet != 0) MessageBox.Show("Failed to disconnect Lights");
            else MessageBox.Show("Disconnected Lights");

            //Disconnect PLC
            if (tcpClient_PLC != null)
            {
                tcpClient_PLC.Dispose();
                MessageBox.Show("Disconnected PLC");
            }
        }

        //Timer Heart Bit
        private void TimerHearBit_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (tcpClient_PLC.Connected == true)
                {
                    try
                    {
                        HeartBits_1();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }));
            
        }

        //Timer Trigger
        private void TimerTrigger_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    bnBegin.Text = i.ToString();
                    i++;
                    if (trigger_signal == "10") Run();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }));
        }

        #region Run
        private void Run()
        {
            //Turn on Lights
            Light.SetIntensity(1, 200);
            Light.SetIntensity(2, 200);
            Light.SetIntensity(3, 200);
            Light.SetIntensity(4, 200);
            Thread.Sleep(100);

            //After 100ms, Acquisit Image
            try
            {
                tbCamera.Run();
                cogRecordDisplay1.InteractiveGraphics.Clear();
                cogRecordDisplay1.StaticGraphics.Clear();
                cogRecordDisplay1.Record = tbCamera.CreateLastRunRecord().SubRecords[0];
                WriteTrigger_0();
                WriteAcqOK();

                Light.SetIntensity(1, 0);
                Light.SetIntensity(2, 0);
                Light.SetIntensity(3, 0);
                Light.SetIntensity(4, 0);

                tbVisionTool.Run();
                cogRecordDisplay2.InteractiveGraphics.Clear();
                cogRecordDisplay2.StaticGraphics.Clear();
                cogRecordDisplay2.Record = tbVisionTool.CreateLastRunRecord().SubRecords[0];

                //if ((string)tbVisionTool.Outputs["Result"].Value == "OK")
                //{
                //    WriteResultOK();
                //}
                //else WriteResultNG();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Event Click Button
        private void bnBegin_Click(object sender, System.EventArgs e)
        {
            timerTrigger.Enabled = true;
            timerTrigger.Start();

            timerHeartBit.Enabled = true;
            timerHeartBit.Start();
        }

        private void bnEnd_Click(object sender, EventArgs e)
        {
            timerTrigger.Stop();
            timerTrigger.Enabled = false;

            timerHeartBit.Stop();
            timerHeartBit.Enabled = false;
        }

        //Setup Camera
        private void tsSetupCamera_Menu1_Click(object sender, System.EventArgs e)
        {
            Setup_Camera setup_Camera = new Setup_Camera();
            setup_Camera.ShowDialog();
        }


        //Setup PLC
        private void tsSetupPLC_Menu1_Click(object sender, System.EventArgs e)
        {
            Connect_PLC connect_PLC = new Connect_PLC(this);
            connect_PLC.tbIpAddress.Text = "192.168.1.100";
            connect_PLC.tbPort.Text = "3000";
            connect_PLC.IPChanged += PLC_IP_Changed;
            connect_PLC.ShowDialog();
        }

        //Setup Lights
        private void tsSetupLights_Menu1_Click(object sender, EventArgs e)
        {

        }

        private void PLC_IP_Changed(object sender, Tuple<string, int> inIP)
        {
            this.IpAddress_PLC = inIP.Item1;
            this.Port_PLC = inIP.Item2;


            this.bnBegin.Text = Convert.ToString(IpAddress_PLC);
            this.bnEnd.Text = Convert.ToString(Port_PLC);

            if(tcpClient_PLC != null) tcpClient_PLC.Dispose();
            IntialPLC();
        }

        

        #endregion

        #region Intialize

        //Intial Program
        private void IntialProgram()
        {
            try
            {
                string CameraPath = AppDomain.CurrentDomain.BaseDirectory + "VPro Program\\" + "Camera.vpp";
                string VisionToolPath = AppDomain.CurrentDomain.BaseDirectory + "VPro Program\\" + "VisionTool.vpp";
                tbCamera = new CogToolBlock();
                tbVisionTool = new CogToolBlock();
                tbCamera = CogSerializer.LoadObjectFromFile(CameraPath) as CogToolBlock;
                tbVisionTool = CogSerializer.LoadObjectFromFile(VisionToolPath) as CogToolBlock;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Intial PLC
        private void IntialPLC()
        {
            if(tcpClient_PLC != null)
            {
                tcpClient_PLC.Dispose();
            }
            try
            {
                tcpClient_PLC = new TcpClient(IpAddress_PLC, Port_PLC);
                stream = tcpClient_PLC.GetStream();
                if (tcpClient_PLC.Connected)
                {
                    lbPLCConnected.Text = "Connected";
                    lbPLCConnected.ForeColor = Color.Green;
                    HeartBits_1();
                    MessageBox.Show("Connected PLC");
                }
                else
                {
                    lbPLCConnected.Text = "Disconnected";
                    lbPLCConnected.ForeColor = Color.Red;
                    MessageBox.Show("Disconnected PLC");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Intial Lights
        private void IntialLights()
        {
            long lRet = -1;
            Light = new OPTControllerAPI();
            try
            {
                lRet = Light.CreateEthernetConnectionByIP(IpAddress_Lights);
                if (0 != lRet)
                {
                    lbLightsConnected.Text = "Disconnected";
                    lbLightsConnected.ForeColor = Color.Red;
                    MessageBox.Show("Cannot connect Lights");
                    return;
                }
                else
                {
                    lbLightsConnected.Text = "Connected";
                    lbLightsConnected.ForeColor = Color.Green;
                    MessageBox.Show("Connected Lights");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
#endregion

        #region Edit read/write register from PLC
        private void ReadTrigger()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0c, 0x00, 0x00,
             0x00, 0x01, 0x04, 0x01, 0x00, 0xe8, 0x03, 0x00, 0x90, 0x01, 0x00};
            stream.Write(request, 0, request.Length);
            byte[] response = new byte[12];
            stream.Read(response, 0, response.Length);
            if (response[9] == 0 && response[10] == 0)  //no error
            {
                trigger_signal = response[11].ToString("X");
            }
        }

        private void WriteTrigger_0()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0xe8, 0x03, 0x00, 0x90, 0x02, 0x00, 0x00};

            stream.Write(request, 0, request.Length);
        }

        private void WriteAcqOK()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0xf2, 0x03, 0x00, 0x90, 0x01, 0x00, 0x10};

            stream.Write(request, 0, request.Length);
        }

        private void WriteResultOK()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0xfc, 0x03, 0x00, 0x90, 0x01, 0x00, 0x10};

            stream.Write(request, 0, request.Length);
        }


        private void WriteResultNG()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0xfd, 0x03, 0x00, 0x90, 0x01, 0x00, 0x10};

            stream.Write(request, 0, request.Length);
        }


        private void ReadModel()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0c, 0x00, 0x00,
             0x00, 0x01, 0x04, 0x00, 0x00, 0xe8, 0x03, 0x00, 0xa8, 0x01, 0x00};
            stream.Write(request, 0, request.Length);
            byte[] response = new byte[13];
            stream.Read(response, 0, response.Length);
            if (response[9] == 0 && response[10] == 0)  //no error
            {
                byte[] d1000 = { response[11], response[12] };
                model = BitConverter.ToInt16(d1000, 0);
            }
        }

        private void HeartBits_1()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0x06, 0x04, 0x00, 0x90, 0x01, 0x00, 0x10};
            stream.Write(request, 0, request.Length);
        }

        private void HeartBits_0()
        {
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0d, 0x00, 0x00,
             0x00, 0x01, 0x14, 0x01, 0x00, 0x06, 0x04, 0x00, 0x90, 0x01, 0x00, 0x00};
            stream.Write(request, 0, request.Length);
        }
        #endregion

        
    }

}
