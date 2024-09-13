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
using HslCommunication.Profinet;

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
        private HslCommunication.Profinet.Melsec.MelsecA1ENet PLC = null;
        private string IpAddress_PLC = "192.168.1.100";
        private int Port_PLC = 3000;

        //Intial connect Lights
        public OPTControllerAPI Light = null;
        private TcpClient tcpClient_Lights = new TcpClient();
        private string IpAddress_Lights = "192.168.1.16";
        //public int Port_Lights = 3000;

        private bool trigger_signal = false;
        private string trigger = "1000";
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
            timerTrigger.Interval = 500;
            timerTrigger.AutoReset = true;
            timerTrigger.Elapsed += TimerTrigger_Elapsed;

            //Loop send HeartBit
            if (timerHeartBit == null) timerHeartBit = new System.Timers.Timer();
            timerHeartBit.Enabled = false;
            timerHeartBit.Interval = 500;
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
            PLC.ConnectClose();
            PLC.Dispose();


        }

        //Timer Heart Bit
        private void TimerHearBit_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                PLC.Write("M1030", (bool)true);
            }));
            
        }

        //Timer Trigger
        private void TimerTrigger_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                try
                {
                    model = PLC.ReadInt16("D1000").Content;
                    

                    bool trigger = PLC.ReadBool("M1000").Content;
                    if (trigger) 
                    {
                        Light.SetIntensity(1, 200);
                        Light.SetIntensity(2, 200);
                        Light.SetIntensity(3, 200);
                        Light.SetIntensity(4, 200);

                        tbCamera.Run();
                        if(tbCamera.AbortRunOnToolFailure) PLC.Write("M1011", (bool)true);
                        else PLC.Write("M1010", (bool)true);
                        Display(cogRecordDisplay1, tbCamera);

                        Light.SetIntensity(1, 0);
                        Light.SetIntensity(2, 0);
                        Light.SetIntensity(3, 0);
                        Light.SetIntensity(4, 0);

                        tbVisionTool.Run();
                        if (tbVisionTool.AbortRunOnToolFailure) PLC.Write("M1021", (bool)true);
                        else PLC.Write("M1020", (bool)false);
                        Display(cogRecordDisplay2, tbVisionTool);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }));
        }

        void Display(CogRecordDisplay dsp, CogToolBlock tb)
        {
            dsp.InteractiveGraphics.Clear();
            dsp.StaticGraphics.Clear();
            dsp.Record = tb.CreateLastRunRecord().SubRecords[0];
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
            //this.IpAddress_PLC = inIP.Item1;
            //this.Port_PLC = inIP.Item2;


            //this.bnBegin.Text = Convert.ToString(IpAddress_PLC);
            //this.bnEnd.Text = Convert.ToString(Port_PLC);

            //if(tcpClient_PLC != null) tcpClient_PLC.Dispose();
            //IntialPLC();
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
            try
            {
                if (PLC == null)
                    PLC = new HslCommunication.Profinet.Melsec.MelsecA1ENet("192.168.1.100",3000);
                OperateResult connect = PLC.ConnectServer();
                if (connect.IsSuccess)
                {
                    lbPLCConnected.Text = "Connected";
                    lbPLCConnected.ForeColor = Color.Green;
                    MessageBox.Show("Connected PLC");
                }
                else
                {
                    lbPLCConnected.Text = "Disconnected";
                    lbPLCConnected.ForeColor = Color.Red;
                    MessageBox.Show("Can not connected PLC");
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
    }
}
