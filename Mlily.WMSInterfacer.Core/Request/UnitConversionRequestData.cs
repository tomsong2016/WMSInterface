using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class UnitConversionRequestData : BaseRequestData
    {
        //<MATNR>000000612300000133</MATNR>
        //         <MEINH>M</MEINH>
        //         <UMREN>3000</UMREN>
        //         <MEINS>PC</MEINS>
        //         <UMREZ>1</UMREZ>

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterielCoding { get; set; }

        /// <summary>
        /// 物料编号(MEINH)
        /// </summary>
        [XmlElement("MEINH")]
        public string MEINH { get; set; }

        /// <summary>
        /// 物料编号(UMREN)
        /// </summary>
        [XmlElement("UMREN")]
        public string UMREN { get; set; }
        
        /// <summary>
        /// 计量单位(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string UnitMeasurement { get; set; }

        /// <summary>
        /// 物料编号(UMREZ)
        /// </summary>
        [XmlElement("UMREZ")]
        public string UMREZ { get; set; }

    }
}
