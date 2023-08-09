using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public class iGameEasyCalc_API
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void iGameEasyCalc_CallBack(iGameEasyCalc_RGBList Receive);

        public const string DllPath = ".\\iGameAPI\\iGameEasyCalc.dll";

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_UnInit();

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_Init();

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_Register_CallBack(iGameEasyCalc_CallBack func);

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_Calc_Effects(iGameEasyCalc_LEDParameter Param);

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameEasyCalc_Start();

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void iGameEasyCalc_Stop();

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern iGameEasyCalc_LEDParameter iGameEasyCalc_Get_Effects();

        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_Set_FPS(int FPS);
    }
}
