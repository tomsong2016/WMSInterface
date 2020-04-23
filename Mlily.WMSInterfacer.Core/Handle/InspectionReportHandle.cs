using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Handle
{
    public class InspectionReportHandle : RequestHandleAbstract
    {
        public override string HandleData(object obj)
        {
            var model = (RequestServiceModel<InspectionReportRequest, InspectionReportResponse>)obj;


            InspectionReportResponse reportResponse = new InspectionReportResponse();

            return XmlSerializerExtent.SerializeXML(reportResponse);
        }

        public override BaseResponse Validate(object obj)
        {
            var model = (RequestServiceModel<InspectionReportRequest, InspectionReportResponse>)obj;

            InspectionReportResponse reportResponse = new InspectionReportResponse();

            return reportResponse;
        }
    }
}
