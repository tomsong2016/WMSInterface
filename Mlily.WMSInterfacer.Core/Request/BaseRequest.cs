using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public abstract class BaseRequest<T,K> where T: BaseRequestData where K : BaseResponse
    {
        
    }

    [Serializable]
    [XmlRoot("SERVICE")]
    public class RequestServiceModel<T, K> : BaseRequest<T, K> where T : BaseRequestData where K :BaseResponse
    {
        [XmlElement("CONTROL")]
        public ControlInfo ControlInfo { get; set; }

        [XmlElement("DATA")]
        public RequestDataInfo<T> ReqeustData { get; set; }
    }

    public class ControlInfo
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

    public class RequestDataInfo<T> where T : BaseRequestData 
    {
        [XmlElement("REQUEST")]
        public RequestInfo<T> RequestInfo { get; set; }
    }

    public class RequestInfo<T> where T: BaseRequestData 
    {
        [XmlElement("REQID")]
        public Guid ReqID { get; set; }

        [XmlElement("CONTENT")]
        public RequestContent<T> Content { get; set; }

    }

    public class RequestContent<T> where T: BaseRequestData 
    {
        [XmlElement("ITMS")]
        public List<T> Items { get; set; }
    }
}
