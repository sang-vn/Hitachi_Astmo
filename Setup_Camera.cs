using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MvCamCtrl.NET;
using System.Runtime.InteropServices;
using System.Threading;

using System.Drawing.Imaging;
using System.Diagnostics;
using System.Collections.ObjectModel;

namespace Hitachi_Astemo
{
    public partial class Setup_Camera : Form
    {
        MyCamera.MV_CC_DEVICE_INFO_LIST m_stDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
        public Setup_Camera()
        {
            InitializeComponent();
            //DeviceListAcq();
        }

        private void ShowErrorMsg(string csMessage, int nErrorNum)
        {
            string errorMsg;
            if (nErrorNum == 0)
            {
                errorMsg = csMessage;
            }
            else
            {
                errorMsg = csMessage + ": Error =" + String.Format("{0:X}", nErrorNum);
            }

            switch (nErrorNum)
            {
                case MyCamera.MV_E_HANDLE: errorMsg += " Error or invalid handle "; break;
                case MyCamera.MV_E_SUPPORT: errorMsg += " Not supported function "; break;
                case MyCamera.MV_E_BUFOVER: errorMsg += " Cache is full "; break;
                case MyCamera.MV_E_CALLORDER: errorMsg += " Function calling order error "; break;
                case MyCamera.MV_E_PARAMETER: errorMsg += " Incorrect parameter "; break;
                case MyCamera.MV_E_RESOURCE: errorMsg += " Applying resource failed "; break;
                case MyCamera.MV_E_NODATA: errorMsg += " No data "; break;
                case MyCamera.MV_E_PRECONDITION: errorMsg += " Precondition error, or running environment changed "; break;
                case MyCamera.MV_E_VERSION: errorMsg += " Version mismatches "; break;
                case MyCamera.MV_E_NOENOUGH_BUF: errorMsg += " Insufficient memory "; break;
                case MyCamera.MV_E_UNKNOW: errorMsg += " Unknown error "; break;
                case MyCamera.MV_E_GC_GENERIC: errorMsg += " General error "; break;
                case MyCamera.MV_E_GC_ACCESS: errorMsg += " Node accessing condition error "; break;
                case MyCamera.MV_E_ACCESS_DENIED: errorMsg += " No permission "; break;
                case MyCamera.MV_E_BUSY: errorMsg += " Device is busy, or network disconnected "; break;
                case MyCamera.MV_E_NETER: errorMsg += " Network error "; break;
            }

            MessageBox.Show(errorMsg, "PROMPT");
        }


        //private void DeviceListAcq()
        //{
        //    // ch:创建设备列表 | en:Create Device List
        //    System.GC.Collect();
        //    cbDeviceList.Items.Clear();
        //    m_stDeviceList.nDeviceNum = 0;
        //    int nRet = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE, ref m_stDeviceList);
        //    if (0 != nRet)
        //    {
        //        ShowErrorMsg("Enumerate devices fail!", 0);
        //        return;
        //    }

        //    // ch:在窗体列表中显示设备名 | en:Display device name in the form list
        //    for (int i = 0; i < m_stDeviceList.nDeviceNum; i++)
        //    {
        //        MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_stDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
        //        string strUserDefinedName = "";
        //        if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE)
        //        {
        //            MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)MyCamera.ByteToStruct(device.stSpecialInfo.stGigEInfo, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

        //            if ((gigeInfo.chUserDefinedName.Length > 0) && (gigeInfo.chUserDefinedName[0] != '\0'))
        //            {
        //                if (MyCamera.IsTextUTF8(gigeInfo.chUserDefinedName))
        //                {
        //                    strUserDefinedName = Encoding.UTF8.GetString(gigeInfo.chUserDefinedName).TrimEnd('\0');
        //                }
        //                else
        //                {
        //                    strUserDefinedName = Encoding.Default.GetString(gigeInfo.chUserDefinedName).TrimEnd('\0');
        //                }
        //                cbDeviceList.Items.Add("GEV: " + strUserDefinedName + " (" + gigeInfo.chSerialNumber + ")");
        //            }
        //            else
        //            {
        //                cbDeviceList.Items.Add("GEV: " + gigeInfo.chManufacturerName + " " + gigeInfo.chModelName + " (" + gigeInfo.chSerialNumber + ")");
        //            }
        //        }
        //        else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
        //        {
        //            MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)MyCamera.ByteToStruct(device.stSpecialInfo.stUsb3VInfo, typeof(MyCamera.MV_USB3_DEVICE_INFO));

        //            if ((usbInfo.chUserDefinedName.Length > 0) && (usbInfo.chUserDefinedName[0] != '\0'))
        //            {
        //                if (MyCamera.IsTextUTF8(usbInfo.chUserDefinedName))
        //                {
        //                    strUserDefinedName = Encoding.UTF8.GetString(usbInfo.chUserDefinedName).TrimEnd('\0');
        //                }
        //                else
        //                {
        //                    strUserDefinedName = Encoding.Default.GetString(usbInfo.chUserDefinedName).TrimEnd('\0');
        //                }
        //                cbDeviceList.Items.Add("U3V: " + strUserDefinedName + " (" + usbInfo.chSerialNumber + ")");
        //            }
        //            else
        //            {
        //                cbDeviceList.Items.Add("U3V: " + usbInfo.chManufacturerName + " " + usbInfo.chModelName + " (" + usbInfo.chSerialNumber + ")");
        //            }
        //        }
        //    }

        //    // ch:选择第一项 | en:Select the first item
        //    if (m_stDeviceList.nDeviceNum != 0)
        //    {
        //        cbDeviceList.SelectedIndex = 0;
        //    }
        //}
    }
}
