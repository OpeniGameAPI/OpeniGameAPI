using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public static class iGameSpaceCalcAPI
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void iGameSpaceCalc_CallBack(iGameSpaceCalc_RGBData Receive);

        public const string DllPath = ".\\iGameAPI\\iGameSpaceCalc.dll";

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameSpaceCalc_UnInit();

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameSpaceCalc_Init();

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameSpaceCalc_Register_CallBack(iGameSpaceCalc_CallBack func);

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameSpaceCalc_Set_Effects(iGameSpaceCalc_LEDParameter Param);

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameSpaceCalc_Start();

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameSpaceCalc_Stop();

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameSpaceCalc_Set_FPS(int FPS);

        [DllImport(".\\iGameAPI\\iGameSpaceCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameSpaceCalc_Get_RGBList_APP(ref iGameSpaceCalc_RGBData RGBData);
    }
}
