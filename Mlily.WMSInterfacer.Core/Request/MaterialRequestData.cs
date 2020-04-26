using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class MaterialRequestData: BaseRequestData
    {
        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterielCoding { get; set; }

        /// <summary>
        /// 物料类型(MATKL)
        /// </summary>
        [XmlElement("MATKL")]
        public string MaterielType { get; set; }

        /// <summary>
        /// 物料名称(MAKTX)
        /// </summary>
        [XmlElement("MAKTX")]
        public string MaterielName { get; set; }

        /// <summary>
        /// 物料名称(SPRAS)
        /// </summary>
        [XmlElement("SPRAS")]
        public string SPRAS { get; set; }

        /// <summary>
        /// 物料名称(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string MEINS { get; set; }

        /// <summary>
        /// 物料名称(GEWEI)
        /// </summary>
        [XmlElement("GEWEI")]
        public string GEWEI { get; set; }
    }
}
