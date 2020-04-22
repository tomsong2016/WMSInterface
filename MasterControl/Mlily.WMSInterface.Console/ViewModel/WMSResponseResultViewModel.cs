using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    [Serializable]
    [XmlRoot("Service")]
    public class WMSResponseResultViewModel
    {
        [XmlElement("ServiceResponse")]
        public WMSServiceResponse ServiceResponse { get; set; }


        [XmlElement("Data")]
        public WMSResponseDataInfo Data { get; set; }
    }


    public class WMSServiceResponse
    {
        [XmlElement("Returncode")]
        public string Returncode { get; set; }
    }

    public class WMSResponseDataInfo
    {
        [XmlElement("Response")]
        public WMSResultInfo ResultInfo { get; set; }
    }

    public class WMSResultInfo
    {
        [XmlElement("ReqID")]
        public string ReqID { get; set; }

        [XmlElement("SubReturncode")]
        public int SubReturncode { get; set; }

        [XmlElement("SubReturninfo")]
        public string SubReturninfo { get; set; }

        [XmlElement("Reserve")]
        public string Reserve { get; set; }

    }
}
