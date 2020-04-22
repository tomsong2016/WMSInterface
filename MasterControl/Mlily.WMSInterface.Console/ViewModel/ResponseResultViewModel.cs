using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    [Serializable]
    [XmlRootAttribute("SERVICE")]
    public class ResponseResultViewModel
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