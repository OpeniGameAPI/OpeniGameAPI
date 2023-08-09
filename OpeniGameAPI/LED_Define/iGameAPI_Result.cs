using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpeniGameAPI.Service.CSharp
{
    public enum iGameAPI_Result
    {
        Success,
        UnknowError,
        Uninitialized,
        ParamInvalid,
        WMIError,
        NVAPIError,
        DeviceError,
        UpdateError,
        SystemError,
        DeviceNotSupport
    }
}
