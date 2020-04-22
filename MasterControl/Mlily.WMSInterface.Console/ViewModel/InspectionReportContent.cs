using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM000200035 报检结果推送WMS更新库存状态
    /// </summary>
    public class InspectionReportContent : ContentAbstract
    {
        /// <summary>
        /// ASN号(WMASN)
        /// </summary>
        [XmlElement("WMASN")]
        public string ASN { get;set;}

        /// <summary>
        /// 采购凭证编号(EBELN)
        /// </summary>
        [XmlElement("EBELN")]
        public string  POCoding {get;set;}

        /// <summary>
        /// 采购凭证的项目编号(EBELP) 
        /// </summary>
        [XmlElement("EBELP")]
        public string  PORow {get;set;}

        /// <summary>
        /// 采购凭证类型(BSART)
        /// </summary>
        [XmlElement("BSART")]
        public string POType { get;set;}

        /// <summary>
        /// 供应商或债权人的帐号(LIFNR)
        /// </summary>
        [XmlElement("LIFNR")]
        public string SupplierCoding { get;set;}

        /// <summary>
        /// 名称(NAME1)
        /// </summary>
        [XmlElement("NAME1")]
        public string Supplier { get;set;}

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get;set;}

        /// <summary>
        /// 收货数量(GRQTY)
        /// </summary>
        [XmlElement("GRQTY")]
        public decimal Quantity { get;set;}

        [XmlIgnore]
        public DateTime DeliveryDate { get;set;}

        /// <summary>
        /// 交货日期(DHDAT)
        /// </summary>
        [XmlElement("DHDAT")]
        public string DeliveryDateValue
        {
            get { return DeliveryDate.ToString("yyyyMMdd"); }
            set { DeliveryDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 工厂(WERKS)
        /// </summary>
        [XmlElement("WERKS")]
        public string FactoryCoding { get;set;}

        /// <summary>
        /// 库存地点(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string LocationCoding { get;set;}

        /// <summary>
        /// MES返回报检处理状态(MES_INS_RESULT)
        /// </summary>
        [XmlElement("MES_INS_RESULT")]
        public string MesResult { get; set; }

    }
}