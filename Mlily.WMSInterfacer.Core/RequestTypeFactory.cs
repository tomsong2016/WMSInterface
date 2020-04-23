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
            switch (data)
            {
                case "INT_MM000200035":
                    return typeof(DefaultRequestModel<InspectionReportRequest, InspectionReportResponse>);

                default:
                    return null;
            }
        }
    }
}
