using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class WarehouseRequestData : BaseRequestData
    {
        //<WERKS>1301</WERKS>
        //            <LGORT>5201</LGORT>
        //            <LGOBE>天霖仓</LGOBE>

        /// <summary>
        /// 工厂(WERKS)
        /// </summary>
        [XmlElement("WERKS")]
        public string FactoryCoding { get; set; }

        /// <summary>
        /// 库存地点(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string StockLocationCoding { get; set; }

        /// <summary>
        /// 库存地点名称(LGORT)
        /// </summary>
        [XmlElement("LGOBE")]
        public string StockLocationName { get; set; }
    }
}
