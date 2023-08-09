using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameSpaceCalc_RGBData
    {
        public int X_length;

        public int Y_length;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public iGameSpaceCalc_Line[] axis_X;

        public iGameSpaceCalc_RGBData(int a)
        {
            X_length = 100;
            Y_length = 100;
            axis_X = new iGameSpaceCalc_Line[100];
            for (int i = 0; i < 100; i++)
            {
                axis_X[i] = new iGameSpaceCalc_Line(0);
            }
        }
    }
}
