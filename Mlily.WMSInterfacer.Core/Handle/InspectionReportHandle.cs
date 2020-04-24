using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Handle
{
    [ServiceId("INT_MM000200035")]
    public class InspectionReportHandle : RequestHandleAbstract
    {
        public override string HandleData(object obj)
        {
            var model = (DefaultRequestModel<InspectionReportRequestData, InspectionReportResponse>)obj;
            var reportResponse = InspectionReportResponse.OK(model.ReqeustData.RequestInfo.ReqID);

            //Debug.WriteLine(model.ReqeustData.RequestInfo.Content.Items.Count);
            return reportResponse.Serializer(typeof(InspectionReportResponse));          //XmlSerializerExtent.SerializeXML(reportResponse);
        }

        public override BaseResponse HandleDataExtent(object obj)
        {
            throw new NotImplementedException();
        }

        public override BaseResponse Validate(object obj)
        {
            var model = (DefaultRequestModel<InspectionReportRequestData, InspectionReportResponse>)obj;
            var reportResponse = InspectionReportResponse.OK(model.ReqeustData.RequestInfo.ReqID);

            return reportResponse;
        }
    }
}
