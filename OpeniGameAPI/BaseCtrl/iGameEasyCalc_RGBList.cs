using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameEasyCalc_RGBList
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public RGB[] RGBList;

        public int Count;
    }
}
