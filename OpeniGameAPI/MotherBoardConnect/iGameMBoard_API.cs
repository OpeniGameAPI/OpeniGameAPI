using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public class iGameMBoard_API
    {
        public const string DllPath = ".\\iGameAPI\\iGameMBoard.dll";

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Init();

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_UnInit();

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int iGameMBoard_Get_Device_Count();

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameMBoard_Get_Device_Info(int index, ref iGameMBoard_DeviceBuffer Device);

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Set_DeviceCalc_Effects(iGameMBoard_DeviceBuffer Device, iGameEasyCalc_LEDParameter Param);

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Set_EasyCalc_Effects(iGameMBoard_DeviceBuffer Device);

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Set_SpaceCalc_Effects(iGameMBoard_DeviceBuffer Device, iGameSpaceCalc_DevicePointList_MBoard PointList);

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Set_FPS(int FPS);

        [DllImport(".\\iGameAPI\\iGameMBoard.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameMBoard_Set_DeviceLEDTest(iGameMBoard_DeviceBuffer Device, int Port, int Index);
    }
}
