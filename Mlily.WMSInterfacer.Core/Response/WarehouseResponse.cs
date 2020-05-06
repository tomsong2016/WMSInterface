using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Response
{
    [Serializable]
    [XmlRoot("SERVICE")]
    public class WarehouseResponse : DefaultResponseModel
    {
    }
}
