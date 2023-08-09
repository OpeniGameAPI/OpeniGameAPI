using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameSpaceCalc_PointList
    {
        public int Length;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        public iGameSpaceCalc_Point[] Points;

        public iGameSpaceCalc_PointList(int x, int y)
        {
            Length = 100;
            Points = new iGameSpaceCalc_Point[Length];
            for (int i = 0; i < Length; i++)
            {
                Points[i].X = x;
                Points[i].Y = y;
            }
        }
    }
}
