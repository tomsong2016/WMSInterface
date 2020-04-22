using System.Collections.Generic;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    public abstract class ContentAbstract
    {
        
    }


    public class ResponseBodyContentA : ContentAbstract
    {
        [XmlElement("WMASN")]
        public string ASN { get; set; }
    }
}