using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameSpaceCalc_LEDParameter
    {
        public int X_length;

        public int Y_length;

        public iGameSpaceCalc_LEDType LEDType;

        public RGB Color;

        public float Brightness;

        public int Speed;

        public int Sensitivity;

        public int FPS;

        public int Direction;

        public override string ToString()
        {
            return string.Format("{0}:{1},", "Speed", Speed) + "LEDType:" + LEDType.ToString() + "," + string.Format("{0}:{1},", "Brightness", Brightness) + string.Format("{0}:{1},", "FPS", FPS) + string.Format("{0}:{1},", "Sensitivity", Sensitivity) + string.Format("{0}:R{1},G:{2},B:{3}", "Color", Color.r, Color.g, Color.b);
        }

        public iGameSpaceCalc_LEDParameter(int A)
        {
            X_length = 100;
            Y_length = 100;
            LEDType = iGameSpaceCalc_LEDType.Rainbow;
            Color.r = byte.MaxValue;
            Color.g = 0;
            Color.b = 0;
            Brightness = 1f;
            Sensitivity = 10;
            Speed = 5;
            FPS = 40;
            Direction = 0;
        }
    }
}
