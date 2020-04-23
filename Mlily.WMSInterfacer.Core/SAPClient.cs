using Mlily.WMSInterfacer.Core.Handle;
using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    public class SAPClient:IClient
    {
        public string Excute(string data) 
        {
            RequestHandleAbstract handleAbstract = new InspectionReportHandle();

            return handleAbstract.Handle(data.Deserialize(RequestTypeFactory.Get(data)));
        }
    }
}
