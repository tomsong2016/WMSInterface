using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    public interface IClient
    {
        string Excute(string data);
    }
}
