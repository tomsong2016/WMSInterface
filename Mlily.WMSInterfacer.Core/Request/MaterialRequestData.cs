﻿using System;
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
        /// 语言(SPRAS)
        /// </summary>
        [XmlElement("SPRAS")]
        public string Language { get; set; }

        /// <summary>
        /// 计量单位(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string UnitMeasurement { get; set; }

        /// <summary>
        /// 重量单位(GEWEI)
        /// </summary>
        [XmlElement("GEWEI")]
        public string WeightUnit { get; set; }
    }
}
