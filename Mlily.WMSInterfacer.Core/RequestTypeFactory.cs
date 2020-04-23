using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    public class RequestTypeFactory
    {
        public static Type Get(string data)
        {
            return typeof(RequestServiceModel<InspectionReportRequest, InspectionReportResponse>);
        }
    }
}
