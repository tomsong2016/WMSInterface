using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Handle
{
    [ServiceId("INT_MM000200011")]
    public class WorkshopMaterialHandle : RequestHandleAbstract
    {
        public override string HandleData(object obj)
        {
            var model = (DefaultRequestModel<WorkshopMaterialRequestData, WorkshopMaterialResponse>)obj;
            //Debug.WriteLine(model.ReqeustData.RequestInfo.Content.Items.Count);
            var reportResponse = WorkshopMaterialResponse.OK(model.ReqeustData.RequestInfo.ReqID);



            return reportResponse.Serializer(typeof(WorkshopMaterialResponse));
        }

        public override BaseResponse HandleDataExtent(object obj)
        {
            throw new NotImplementedException();
        }

        public override BaseResponse Validate(object obj)
        {
            var model = (DefaultRequestModel<WorkshopMaterialRequestData, WorkshopMaterialResponse>)obj;
            var reportResponse = WorkshopMaterialResponse.OK(model.ReqeustData.RequestInfo.ReqID);
            return reportResponse;
        }
    }
}
