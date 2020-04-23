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
            var model = (DefaultRequestModel<WorkshopMaterialRequest, WorkshopMaterialResponse>)obj;
            //Debug.WriteLine(model.ReqeustData.RequestInfo.Content.Items.Count);

            WorkshopMaterialResponse reportResponse = new WorkshopMaterialResponse();
            reportResponse.IsSuccess = true;

            ServiceResponse serviceResponse = new ServiceResponse();
            serviceResponse.Returncode = "0";
            reportResponse.ServiceResponse = serviceResponse;

            ResponseDataInfo dataInfo = new ResponseDataInfo();
            ResultInfo resultInfo = new ResultInfo();
            resultInfo.ReqID = model.ReqeustData.RequestInfo.ReqID;
            resultInfo.SubReturncode = 0;
            resultInfo.SubReturncode = 0;
            resultInfo.Reserve = "OK";

            dataInfo.ResultInfo = resultInfo;
            reportResponse.Data = dataInfo;



            return reportResponse.Serializer(typeof(WorkshopMaterialResponse));
        }

        public override BaseResponse Validate(object obj)
        {
            var model = (DefaultRequestModel<WorkshopMaterialRequest, WorkshopMaterialResponse>)obj;


            WorkshopMaterialResponse reportResponse = new WorkshopMaterialResponse();
            reportResponse.IsSuccess = true;
            return reportResponse;
        }
    }
}
