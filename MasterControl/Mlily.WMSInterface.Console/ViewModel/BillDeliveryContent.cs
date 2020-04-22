using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM002100009 交货单发货过账
    /// </summary>
    public class BillDeliveryContent : ContentAbstract
    {
        [XmlIgnore]
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// 发货日期(WADAT)
        /// </summary>
        [XmlElement("WADAT")]
        public string DeliveryDateVale
        {
            get { return DeliveryDate.ToString("yyyyMMdd"); }
            set { DeliveryDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 交货单(VBELN)
        /// </summary>
        [XmlElement("VBELN")]
        public string DeliveryOrderCoding { get;set;}

        /// <summary>
        /// 交货项目(POSNR)
        /// </summary>
        [XmlElement("POSNR")]
        public string DeliveryRow { get;set;}

        /// <summary>
        /// 实际交货量(LFIMG)
        /// </summary>
        [XmlElement("LFIMG")]
        public decimal Quantity { get;set;}

        /// <summary>
        /// 基本计量单位(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string UnitName { get; set; }

    }
}