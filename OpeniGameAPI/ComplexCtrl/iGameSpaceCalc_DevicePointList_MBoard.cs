using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public struct iGameSpaceCalc_DevicePointList_MBoard
    {
        public iGameSpaceCalc_PointList PointList_MBoard;

        public iGameSpaceCalc_PointList PointList_12V_1;

        public iGameSpaceCalc_PointList PointList_12V_2;

        public iGameSpaceCalc_PointList PointList_5V_1;

        public iGameSpaceCalc_PointList PointList_5V_2;

        public iGameSpaceCalc_PointList PointList_5V_3;

        public iGameSpaceCalc_DevicePointList_MBoard(iGameMBoard_LEDInfo info)
        {
            PointList_MBoard = new iGameSpaceCalc_PointList(-1, -1);
            PointList_MBoard.Length = info.MBoard_LED_Count;
            PointList_12V_1 = new iGameSpaceCalc_PointList(-1, -1);
            PointList_12V_1.Length = info.MBoard_12V_1_BAR_LED_Count;
            PointList_12V_2 = new iGameSpaceCalc_PointList(-1, -1);
            PointList_12V_2.Length = info.MBoard_12V_2_BAR_LED_Count;
            PointList_5V_1 = new iGameSpaceCalc_PointList(-1, -1);
            PointList_5V_1.Length = info.MBoard_5V_1_BAR_LED_Count;
            PointList_5V_2 = new iGameSpaceCalc_PointList(-1, -1);
            PointList_5V_2.Length = info.MBoard_5V_2_BAR_LED_Count;
            PointList_5V_3 = new iGameSpaceCalc_PointList(-1, -1);
            PointList_5V_3.Length = info.MBoard_5V_3_BAR_LED_Count;
        }
    }
}
