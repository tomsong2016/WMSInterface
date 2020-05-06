using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class MaterielTypeRequestData : BaseRequestData
    {
        //<SPRAS>D</SPRAS>
        //          <MATKL>01</MATKL>
        //          <WGBEZ>Warengruppe 1</WGBEZ>

        /// <summary>
        /// 语言(SPRAS)
        /// </summary>
        [XmlElement("SPRAS")]
        public string Language { get; set; }

        /// <summary>
        /// 物料类型(MATKL)
        /// </summary>
        [XmlElement("MATKL")]
        public string MaterielType { get; set; } 

        /// <summary>
        /// 物料类型名称(WGBEZ)
        /// </summary>
        [XmlElement("WGBEZ")]
        public string MaterielTypeName { get; set; }

    }
}
