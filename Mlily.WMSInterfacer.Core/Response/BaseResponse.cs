using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Response
{
    public interface BaseResponse
    {
        bool IsSuccess { get; set; }
    }

    public class DefaultResponseModel : BaseResponse
    {
        [XmlElement("SERVICERESPONSE")]
        public ServiceResponse ServiceResponse { get; set; }

        [XmlElement("DATA")]
        public ResponseDataInfo Data { get; set; }

        [XmlIgnore]
        public bool IsSuccess { get; set; }

        public DefaultResponseModel()
        { }

        public DefaultResponseModel(Guid reqId, bool isSuccess, string message)
        {
            this.IsSuccess = isSuccess;
            this.Data = new ResponseDataInfo(reqId, isSuccess, message);
            this.ServiceResponse = new ServiceResponse(isSuccess);
        }

        public static DefaultResponseModel OK(Guid reqId)
        {
            return new DefaultResponseModel(reqId, true, "预留内容");
        }

        public static DefaultResponseModel Bad(Guid reqId, string message)
        {
            return new DefaultResponseModel(reqId, true, message);
        }

        public static DefaultResponseModel SetError(DefaultResponseModel model, string message)
        {
            model.IsSuccess = false;
            model.ServiceResponse.Returncode = 2;
            model.Data.ResultInfo.Reserve = message;
            model.Data.ResultInfo.SubReturncode = 2;
            model.Data.ResultInfo.SubReturninfo = "处理不成功";

            return model;
        }

        public static DefaultResponseModel SetOK(DefaultResponseModel model)
        {
            model.IsSuccess = true;
            model.ServiceResponse.Returncode = 0;
            model.Data.ResultInfo.Reserve = "预留内容";
            model.Data.ResultInfo.SubReturncode = 0;
            model.Data.ResultInfo.SubReturninfo = "处理成功";
            return model;
        }
    }


    public class ServiceResponse
    {
        [XmlElement("RETURNCODE")]
        public int Returncode { get; set; }

        public ServiceResponse(bool isSuccess)
        {
            this.Returncode = isSuccess ? 0 : 2;
        }
    }

    public class ResponseDataInfo
    {
        [XmlElement("RESPONSE")]
        public ResultInfo ResultInfo { get; set; }

        public ResponseDataInfo(Guid reqId, bool isSuccess, string reserve)
        {
            string subReturninfo = isSuccess ? "处理成功" : "处理不成功";
            this.ResultInfo = new ResultInfo(reqId, isSuccess, subReturninfo, reserve);
        }
    }

    public class ResultInfo
    {
        [XmlElement("REQID")]
        public Guid ReqID { get; set; }

        [XmlElement("SUBRETURNCODE")]
        public int SubReturncode { get; set; }

        [XmlElement("SUBRETURNINFO")]
        public string SubReturninfo { get; set; }

        [XmlElement("RESERVE")]
        public string Reserve { get; set; }

        public ResultInfo(Guid reqId, bool isSuccess, string subReturninfo, string reserve)
        {
            this.ReqID = reqId;
            this.SubReturncode = isSuccess ? 0 : 2;
            this.SubReturninfo = subReturninfo;
            this.Reserve = reserve;
        }

    }
}
