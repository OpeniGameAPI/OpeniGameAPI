using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public enum iGameAPI_DeviceType
    {
        Unknow = 0,
        GraphicsCard = 1,
        MotherBoard = 2,
        Mouse = 4,
        Keyboard = 8,
        DRAM = 0x10,
        SSD = 0x20,
        ALL = 0x3F
    }
}
