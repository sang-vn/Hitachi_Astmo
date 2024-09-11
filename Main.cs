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

namespace Hitachi_Astemo
{
    public partial class Main : Form
    {
        private int check_face = 0;

        //Intial connect Camera
        public CogToolBlock toolBlock = new CogToolBlock();
        CogFrameGrabbers myframegrabbers;
        ICogFrameGrabber myframegrabber;
        ICogAcqFifo myFifo;

        //Intial connect PLC 
        private TcpClient tcpClient_PLC = new TcpClient();
        internal string IpAddress_PLC = "192.168.1.100";
        internal int Port_PLC = 3000;
        private Stream stream_PLC = null;

        //Intial connect Lights
        public OPTControllerAPI Light = null;
        private TcpClient tcpClient_Lights = new TcpClient();
        private string IpAddress_Lights = "192.168.1.16";
        //public int Port_Lights = 3000;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            IntialPLC();
            //IntialCamera();
            //IntialLights();
        }




        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ////Disconnect Camera
            //myFifo = null;
            //myframegrabber = null;

            ////Disconnect Lights
            //long lRet = -1;
            //lRet = Light.DestroyEthernetConnect();
            //if (lRet != 0) MessageBox.Show("Failed to disconnect Lights");
            //else MessageBox.Show("Success to disconnect Lights succeed");

            //Disconnect PLC
            if (tcpClient_PLC != null)
            {
                tcpClient_PLC.Dispose();
                MessageBox.Show("Disconnected PLC");
            }
        }



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
        
        private void PLC_IP_Changed(object sender, Tuple<string, int> inIP)
        {
            this.IpAddress_PLC = inIP.Item1;
            this.Port_PLC = inIP.Item2;


            this.bnBegin.Text = Convert.ToString(IpAddress_PLC);
            this.bnEnd.Text = Convert.ToString(Port_PLC);

            if(tcpClient_PLC != null) tcpClient_PLC.Dispose();
            IntialPLC();
        }

        //Connect PLC
        private void IntialPLC()
        {
            if(tcpClient_PLC != null)
            {
                tcpClient_PLC.Dispose();
            }
            try
            {
                tcpClient_PLC = new TcpClient(IpAddress_PLC, Port_PLC);
                stream_PLC = tcpClient_PLC.GetStream();
                if (tcpClient_PLC.Connected)
                {
                    lbPLCConnected.Text = "Connected";
                    lbPLCConnected.ForeColor = Color.Green;
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

        //Connect Camera
        private void IntialCamera()
        {
            myframegrabbers = new CogFrameGrabbers();
            myframegrabber = myframegrabbers[0];
            CogStringCollection availableFormatImages = myframegrabber.AvailableVideoFormats;
            myFifo = myframegrabber.CreateAcqFifo(availableFormatImages[0], Cognex.VisionPro.CogAcqFifoPixelFormatConstants.Format8Grey, 0, false);
        }

        //Connect Lights
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
                    return;
                }
                else
                {
                    lbLightsConnected.Text = "Connected";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        #region Processing
        private void Processing()
        {
            try
            {
                //ReadModel

                //Choose toolblock

                //If check face 1
                if(check_face == 1)
                {
                    try
                    {
                        //while bit m1000 = 0
                        while (false)
                        {
                            //Read bit Trigger M1000

                            //if = 0 continues
                            //if time wait > 4000ms show Error

                            //if = 1 Excute Processing()
                            //and check_face = 2
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                //If check face 2
                if (check_face == 2)
                {
                    try
                    {
                        //while bit m1000 = 0
                        while (false)
                        {
                            //Read bit Trigger M1000

                            //if = 0 continues
                            //if time wait > 4000ms show Error

                            //if = 1 Excute Processing()
                            //and check_face = 3
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }

                //If check face 3
                if (check_face == 3)
                {
                    try
                    {
                        //while bit m1002 = 0
                        while (false)
                        {
                            //Read bit Trigger M1002

                            //if = 0 continues
                            //if time wait > 4000ms show Error

                            //if = 1 Excute Processing()
                            //and check_face = 1
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Run
        private void Run()
        {
            //Turn on Lights
            
            //Wait 20ms, Acquisit Image

            //Write Trigger OK M1010

            //Run toolblock.FaceN

            //Lưu ảnh NG ra bên cạnh

            //Write OK/NG

        }
        #endregion

        private void bnBegin_Click(object sender, System.EventArgs e)
        {

        }

       
    }

}
