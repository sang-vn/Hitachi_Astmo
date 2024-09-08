﻿using System;
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
        private int check_face = 0;

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
            ConnectPLC();
            ConnectCamera();
            ConnectLights();
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

        private void ConnectPLC()
        {
            try
            {
                tcpClient_PLC = new TcpClient(IpAddress_PLC, Port_PLC);
                stream_PLC = tcpClient_PLC.GetStream();
                if (tcpClient_PLC.Connected)
                {
                    lbPLCConnected.Text = "Connected";
                    lbPLCConnected.ForeColor = Color.Green;
                }
                else
                {
                    lbPLCConnected.Text = "Disconnected";
                    lbPLCConnected.ForeColor = Color.Red;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Setup Camera
        private void ConnectCamera()
        {

        }

        //Setup Lights
        private void ConnectLights()
        {
            try
            {
                tcpClient_Lights = new TcpClient(IpAddress_Lights, Port_Lights);
                stream_Lights = tcpClient_Lights.GetStream();
                if (tcpClient_Lights.Connected)
                {
                    lbLightsConnected.Text = "Connected";
                    lbLightsConnected.ForeColor = Color.Green;
                }
                else
                {
                    lbLightsConnected.Text = "Disconnected";
                    lbLightsConnected.ForeColor = Color.Red;
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
    }

}
