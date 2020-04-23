using Mlily.WMSInterfacer.Core.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Response
{
    public interface BaseResponse
    {
    }

    [Serializable]
    [XmlRootAttribute("SERVICE")]
    public class ResponseServiceModel: BaseResponse
    {
        [XmlElement("SERVICERESPONSE")]
        public ServiceResponse ServiceResponse { get; set; }


        [XmlElement("DATA")]
        public ResponseDataInfo Data { get; set; }
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
        public string ReqID { get; set; }

        [XmlElement("SUBRETURNCODE")]
        public int SubReturncode { get; set; }

        [XmlElement("SUBRETURNINFO")]
        public string SubReturninfo { get; set; }

        [XmlElement("RESERVE")]
        public string Reserve { get; set; }

    }
}
