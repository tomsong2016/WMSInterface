using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Response
{
    public interface BaseResponse
    {
        bool IsSuccess { get; set; }
    }

    public class DefaultResponseModel: BaseResponse
    {
        [XmlElement("SERVICERESPONSE")]
        public ServiceResponse ServiceResponse { get; set; }

        [XmlElement("DATA")]
        public ResponseDataInfo Data { get; set; }

        [XmlIgnore]
        public bool IsSuccess { get; set; }
    }


    public class ServiceResponse
    {
        [XmlElement("RETURNCODE")]
        public string Returncode { get; set; }
    }

    public class ResponseDataInfo
    {
        [XmlElement("RESPONSE")]
        public ResultInfo ResultInfo { get; set; }
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

    }
}
