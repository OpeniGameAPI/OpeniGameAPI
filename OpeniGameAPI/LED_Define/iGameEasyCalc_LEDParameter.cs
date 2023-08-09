using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp.LED
{
    public struct iGameEasyCalc_LEDParameter
    {
        public iGameEasyCalc_LEDType LEDType;

        public RGB Color;

        public float Brightness;

        public int Sensitivity;

        public int Speed;

        public int LEDCount;

        public int FPS;

        public int Direction;

        public iGameEasyCalc_LEDParameter(int A)
        {
            LEDType = iGameEasyCalc_LEDType.Rainbow;
            Color.r = byte.MaxValue;
            Color.g = 0;
            Color.b = 0;
            Brightness = 1f;
            Sensitivity = 10;
            Speed = 5;
            LEDCount = 100;
            FPS = 40;
            Direction = 0;
        }

        public iGameEasyCalc_LEDParameter(byte[] received)
        {
            LEDType = (iGameEasyCalc_LEDType)received[2];
            Color.r = received[3];
            Color.g = received[4];
            Color.b = received[5];
            Brightness = (float)(int)received[6] / 255f;
            Sensitivity = 0;
            Sensitivity += received[7] << 8;
            Sensitivity += received[8];
            Speed = received[9];
            LEDCount = received[10];
            FPS = received[11];
            Direction = received[12];
        }
    }
}
