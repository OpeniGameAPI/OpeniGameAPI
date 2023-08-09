using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameMBoard_Device
    {
        public string DeviceName;

        public string DeviceID;

        public int DeviceIndex;

        public iGameMBoard_LEDInfo DeviceLEDInfo;

        public iGameLEDCalcMode DeviceLEDMode;

        public iGameSpaceCalc_DevicePointList_MBoard DevicePointList;
    }
}
