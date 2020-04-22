using System;
using System.Collections.Generic;
using System.Xml.Serialization;
// ReSharper disable All

namespace Mlily.WMSInterface.Console.ViewModel
{
    [Serializable]
    [XmlRoot("Service")]
    public class RequestResultViewModel<T> where T : ContentAbstract
    {
        [XmlElement("Control")]
        public ControlInfo ControlInfo { get; set; }

        [XmlElement("Data")]
        public RequestDataInfo<T> ReqeustData { get; set; }
    }

    public class ControlInfo
    {
        [XmlElement("ServiceID")]
        public string ServiceID { get; set; }

        [XmlElement("SrvGUID")]
        public Guid SrvGUID { get; set; }

        [XmlElement("SrvTimestamp")]
        public string SrvTimestampValue
        {
            get { return SrvTimestamp.ToString("yyyyMMddHHmmss"); }
            set { SrvTimestamp = DateTime.ParseExact(value, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime SrvTimestamp { get; set; }

        [XmlElement("SourceSysID")]
        public string SourceSysID { get; set; }

        [XmlElement("TargetSysID")]
        public string TargetSysID { get; set; }

    }

    public class RequestDataInfo<T> where T : ContentAbstract
    {
        [XmlElement("Request")]
        public RequestInfo<T> RequestInfo { get; set; }
    }

    public class RequestInfo<T> where T : ContentAbstract
    {
        [XmlElement("ReqID")]
        public Guid ReqID { get; set; }

        [XmlElement("Content")]
        public RequestContent<T> Content { get; set; }

    }
 
    public class RequestContent<T> where T : ContentAbstract
    {
        [XmlElement("itms")]
        public List<T> Items { get; set; }

    }
}