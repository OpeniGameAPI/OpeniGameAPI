using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp.LED
{
    public class LEDAPI
    {
        [DllImport(".\\iGameAPI\\iGameEasyCalc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool iGameEasyCalc_Calc_Effects(iGameEasyCalc_LEDParameter Param);
    }
}
