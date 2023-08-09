using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameMBoard_DeviceBuffer
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
        public byte[] DeviceName;

        public int VID;

        public int PID;

        public int FirstIndex;

        public int SecondIndex;

        public iGameMBoard_ICType Type;

        public iGameMBoard_LEDInfo LEDInfo;

        public iGameLEDCalcMode DeviceLEDMode;
    }
}
