using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    [Serializable]
    [XmlRoot("SERVICE")]
    public class ResponseBodyViewModel<T> where T: ContentAbstract
    {
        [XmlElement("CONTROL")]
        public ResponseControlInfo ControlInfo { get; set; }

        [XmlElement("DATA")]
        public RequestResponseDataInfo<T> RequestData { get; set; }
    }

    public class ResponseControlInfo
    {
        [XmlElement("SERVICEID")]
        public string ServiceID { get; set; }

        [XmlElement("SRVGUID")]
        public Guid SrvGUID { get; set; }

        [XmlElement("SRVTIMESTAMP")]
        public string SrvTimestampValue
        {
            get { return SrvTimestamp.ToString("yyyyMMddHHmmss"); }
            set { SrvTimestamp = DateTime.ParseExact(value, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime SrvTimestamp { get; set; }

        [XmlElement("SOURCESYSID")]
        public string SourceSysID { get; set; }

        [XmlElement("TARGETSYSID")]
        public string TargetSysID { get; set; }
    }

    public class RequestResponseDataInfo<T> where T : ContentAbstract
    {
        [XmlElement("REQUEST")]
        public RequestResponseInfo<T> RequestInfo { get; set; }
    }

    public class RequestResponseInfo<T> where T : ContentAbstract
    {
        [XmlElement("REQID")]
        public Guid ReqId { get; set; }

        [XmlElement("CONTENT")]
        public Items<T> Content { get; set; }

    }

    public class Items<T> where T : ContentAbstract
    {
        [XmlElement("ITMS")]
        public List<T> ItemList { get; set; }
    }
}