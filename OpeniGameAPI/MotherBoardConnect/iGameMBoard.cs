using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public class iGameMBoard
    {
        public iGameMBoard_Device[] DeviceList;

        public int DeviceListCount;

        public iGameMBoard_DeviceBuffer[] DeviceBufferList;

        public bool Init()
        {
            bool flag = iGameMBoard_API.iGameMBoard_Init();
            if (flag)
            {
                DeviceListCount = iGameMBoard_API.iGameMBoard_Get_Device_Count();
                DeviceList = new iGameMBoard_Device[DeviceListCount];
                DeviceBufferList = new iGameMBoard_DeviceBuffer[DeviceListCount];
                for (int i = 0; i < DeviceListCount; i++)
                {
                    iGameMBoard_API.iGameMBoard_Get_Device_Info(i, ref DeviceBufferList[i]);
                    DeviceList[i] = default(iGameMBoard_Device);
                    DeviceList[i].DeviceName = Encoding.Unicode.GetString(DeviceBufferList[i].DeviceName).TrimEnd(default(char));
                    DeviceList[i].DeviceIndex = i;
                    DeviceList[i].DeviceLEDInfo = DeviceBufferList[i].LEDInfo;
                    DeviceList[i].DeviceID = "MBoard_" + DeviceList[i].DeviceIndex + "_" + DeviceList[i].DeviceName.TrimEnd(default(char));
                    DeviceList[i].DevicePointList = new iGameSpaceCalc_DevicePointList_MBoard(DeviceList[i].DeviceLEDInfo);
                    DeviceList[i].DeviceLEDMode = iGameLEDCalcMode.EasyCalc;
                    DeviceBufferList[i].DeviceLEDMode = iGameLEDCalcMode.EasyCalc;
                    iGameMBoard_API.iGameMBoard_Set_EasyCalc_Effects(DeviceBufferList[i]);
                }
            }

            return flag;
        }

        public bool Set_DeviceCalc_Effects(iGameMBoard_Device Device, iGameEasyCalc_LEDParameter Param)
        {
            Device.DeviceLEDMode = iGameLEDCalcMode.DeviceCalc;
            DeviceList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.DeviceCalc;
            DeviceBufferList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.DeviceCalc;
            return iGameMBoard_API.iGameMBoard_Set_DeviceCalc_Effects(DeviceBufferList[Device.DeviceIndex], Param);
        }

        public bool Set_EasyCalc_Effects(iGameMBoard_Device Device)
        {
            DeviceList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.EasyCalc;
            DeviceBufferList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.EasyCalc;
            return iGameMBoard_API.iGameMBoard_Set_EasyCalc_Effects(DeviceBufferList[Device.DeviceIndex]);
        }

        public bool Set_SpaceCalc_Effects(iGameMBoard_Device Device)
        {
            DeviceList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.SpaceCalc;
            DeviceBufferList[Device.DeviceIndex].DeviceLEDMode = iGameLEDCalcMode.SpaceCalc;
            return iGameMBoard_API.iGameMBoard_Set_SpaceCalc_Effects(DeviceBufferList[Device.DeviceIndex], DeviceList[Device.DeviceIndex].DevicePointList);
        }

        public bool Set_FPS(int FPS)
        {
            return iGameMBoard_API.iGameMBoard_Set_FPS(FPS);
        }

        public bool Set_DeviceLEDTest(iGameMBoard_Device Device, int Port, int Index)
        {
            return iGameMBoard_API.iGameMBoard_Set_DeviceLEDTest(DeviceBufferList[Device.DeviceIndex], Port, Index);
        }
    }
}
