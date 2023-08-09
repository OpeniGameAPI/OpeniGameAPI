using OpeniGameAPI.Service.CSharp;
using OpeniGameAPI.Service.CSharp.LED;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class Program
    {
        LEDAPI LEDAPI = new LEDAPI();
        static void Main(string[] args)
        {
            iGameMBoard iGameMBoard = new iGameMBoard();

            var test2 = default(iGameEasyCalc_LEDParameter);
            test2.Brightness = 0;
            test2.LEDType = iGameEasyCalc_LEDType.Static;
            test2.Color = new RGB
            {
                r = 114,
                g = 191,
                b = 191,
            };
            test2.LEDCount = 100;
            test2.Speed = 5;

            iGameSpaceCalcAPI.iGameSpaceCalc_Stop();
            iGameEasyCalc_API.iGameEasyCalc_Stop();

            iGameSpaceCalcAPI.iGameSpaceCalc_Init();
            iGameEasyCalc_API.iGameEasyCalc_Init();

            iGameMBoard.Init();
            Console.WriteLine(LEDAPI.iGameEasyCalc_Calc_Effects(test2));
            test2.Brightness = 255;
            Console.WriteLine(LEDAPI.iGameEasyCalc_Calc_Effects(test2));
            Console.WriteLine(new iGameMBoard_DeviceBuffer().Type);
            Console.ReadLine();
        }
    }
}
