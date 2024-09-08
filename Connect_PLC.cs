using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using OpenCvSharp;
using System.IO;
using System.Collections;

namespace Hitachi_Astemo
{
    public partial class Connect_PLC : Form
    {
        public TcpClient tcpClient = new TcpClient();
        public string IpAddress;
        public int Port;
        Stream stream = null;
        
        
        public Connect_PLC()
        {
            InitializeComponent();
            this.Load += new EventHandler(Connect_PLC_Load);
        }

        private void bnConnect_Click(object sender, EventArgs e)
        {
            if (bnConnect.Text == "Connect")
            {
                IpAddress = tbIpAddress.Text;
                Port = int.Parse(tbPort.Text);
                try
                {
                    tcpClient = new TcpClient(IpAddress, Port);
                    stream = tcpClient.GetStream();
                    if (tcpClient.Connected)
                    {
                        bnConnect.Text = "Disconnect";
                        lbNotice.Text = "Connected";
                        lbNotice.BackColor = Color.Green;
                        tbSentData.Text = "<--- Choose this before send data";
                        cbReadMode.Enabled = true;
                        cbWriteMode.Enabled = true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bnConnect.Text == "Disconnect")
            {
                stream.Close();
                tcpClient.Close();
                bnConnect.Text = "Connect";
                lbNotice.Text = "Disconnected";
                lbNotice.BackColor = Color.Red;
            }
        }

        private void bnSend1_Click(object sender, EventArgs e)
        {
            //Write ON/OFF bits Y
            byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0f, 0x00, 0x00
            , 0x00, 0x01, 0x14, 0x01, 0x00, 0x00, 0x00, 0x00, 0x9d, 0x05, 0x00, 0x11, 0x11, 0x10};

            //Write to D register
            //byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x10, 0x00, 0x00
            //, 0x00, 0x01, 0x14, 0x00, 0x00, 0x64, 0x00, 0x00, 0xa8, 0x02, 0x00, 0x62, 0x62, 0x61, 0x61};

            //Request read bits Y
            //byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0f, 0x00, 0x00
            //, 0x00, 0x01, 0x14, 0x01, 0x00, 0x00, 0x00, 0x00, 0x9d, 0x05, 0x00, 0x00, 0x00, 0x00};

            //Request read to D register
            //byte[] request = {0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00, 0x0f, 0x00, 0x00
            //, 0x00, 0x01, 0x14, 0x01, 0x00, 0x00, 0x00, 0x00, 0x9d, 0x05, 0x00, 0x00, 0x00, 0x00};

            stream.Write(request, 0, request.Length);
            string dataSend = string.Join(", ", request.Select(b => "0x" + b.ToString("X2")));
            tbSentData.Text = dataSend;
        }

        private List<byte> ByteArray()
        {
            List<byte> bytes = new List<byte>();

            //Subheader, Request destination Network No, Request destination Station No
            //Request detination Module IO No, Request destination multidrop station No
            List<byte> headByte = new List<byte> { 0x50, 0x00, 0x00, 0xff, 0xff, 0x03, 0x00 };

            //Request data length
            List<byte> lengthYregister = new List<byte> { 0x0c, 0x00 };

            //Monitoring Timer
            List<byte> timer = new List<byte> { 0x00, 0x00 };

            //Comand 
            List<byte> ReadComand = new List<byte> { 0x01, 0x04 };
            List<byte> WriteComand = new List<byte> { 0x01, 0x14 };
            List<byte> Comand = new List<byte> { 0x01, 0x14 };

            //Subcomand
            List<byte> SubComand = new List<byte> { 0x0c, 0x00 };

            //Device Code
            byte Register = 0xa8;
            switch(cbbRegister.SelectedText)
            {
                case "Y": 
                    Register = 0x9d;
                    break;
                case "D":
                    Register = 0xa8;
                    break;
                case "M":
                    Register = 0x80;
                    break;
                case "T":
                    Register = 0x90;
                    break;
                case "C":
                    Register = 0xa0;
                    break;
                case "X":
                    Register = 0x8d;
                    break;
                default: 
                    break;
            }

            //

            return bytes;
        }

        private void Connect_PLC_FormClosing(object sender, FormClosingEventArgs e)
        {
            //stream.Close();
            //tcpClient.Close();
        }

        private void Connect_PLC_Load(object sender, EventArgs e)
        {
            cbReadMode.Enabled = false;
            cbWriteMode.Enabled = false;
            cbbRegister.Enabled = false;
            tbBeginRegisterRead.Enabled = false;
            tbNumRegisterRead.Enabled = false;
        }

        private void cbReadMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReadMode.Checked)
            {
                cbWriteMode.Enabled = false;
                cbbRegister.Enabled = true;
                tbBeginRegisterRead.Enabled = true;
                tbNumRegisterRead.Enabled = true;
            }
            if (!cbReadMode.Checked)
            {
                cbWriteMode.Enabled = true;
                cbbRegister.Enabled = false;
                tbBeginRegisterRead.Enabled = false;
                tbNumRegisterRead.Enabled = false;
            }
        }

        private void cbWriteMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWriteMode.Checked)
            {
                cbReadMode.Enabled = false;
                cbbRegister.Enabled = true;
                tbBeginRegisterRead.Enabled = true;
                tbNumRegisterRead.Enabled = true;
            }
            if (!cbWriteMode.Checked)
            {
                cbReadMode.Enabled = true;
                cbbRegister.Enabled = false;
                tbBeginRegisterRead.Enabled = false;
                tbNumRegisterRead.Enabled = false;
            }
        }

        public string IP_PLC
        {
            get { return tbIpAddress.Text; }
            set { tbIpAddress.Text = value; }
        }

        public int Port_PLC
        {
            get { return int.Parse(tbPort.Text); }
            set { tbIpAddress.Text = value.ToString(); }
        }

        public event EventHandler<Tuple<string, int>> IPChanged;

        private void bnSave_Click(object sender, EventArgs e)
        {
            IPChanged?.Invoke(this, new Tuple<string, int> (IP_PLC, Port_PLC));
        }
        
    }
}
