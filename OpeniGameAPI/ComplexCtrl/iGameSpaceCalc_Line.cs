using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameSpaceCalc_Line
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public RGB[] axis_Y;

        public iGameSpaceCalc_Line(int A)
        {
            axis_Y = new RGB[100];
        }
    }
}
