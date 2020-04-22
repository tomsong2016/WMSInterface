using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM002100001 WMS上传收货清点送检 Or  INT_MM002100010发送退货采购订单收货
    /// </summary>
    public class ReceivingInventoryContent:ContentAbstract
    {
        /// <summary>
        /// ASN号(WMASN)
        /// </summary>
        [XmlElement("WMASN")]
        public string ASN { get; set; }

        /// <summary>
        /// 采购凭证类型(BSART)
        /// </summary>
        [XmlElement("BSART")]
        public string POType { get; set; }

        /// <summary>
        /// 采购订单(EBELN)
        /// </summary>
        [XmlElement("EBELN")]
        public string PONumber { get; set; }

        /// <summary>
        /// 订单行项目(EBELP)
        /// </summary>
        [XmlElement("EBELP")]
        public string PORow { get; set; }

        /// <summary>
        /// 公司代码(BUKRS)
        /// </summary>
        [XmlElement("BUKRS")]
        public string CompanyCoding { get; set; }

        /// <summary>
        /// 科目分配类别(KNTTP)
        /// </summary>
        [XmlElement("KNTTP")]
        public string SubjectCategory { get; set; }

        /// <summary>
        /// 供应商编码(LIFNR)
        /// </summary>
        [XmlElement("LIFNR")]
        public string SupplierCoding { get; set; }

        /// <summary>
        /// 供应商名称(NAME1)
        /// </summary>
        [XmlElement("NAME1")]
        public string Supplier { get; set; }

        /// <summary>
        /// 物料编码(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get; set; }

        /// <summary>
        /// 收货数量(GRQTY)
        /// </summary>
        [XmlElement("GRQTY")]
        public decimal Quantity { get; set; }
        
        [XmlIgnore]
        public DateTime DeliveryDate { get; set; }

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
        public string FactoryCoding { get; set; }

        /// <summary>
        /// 库存地点(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string LocationCoding { get; set; }

        /// <summary>
        /// WMS收货单号(GRNUM)
        /// </summary>
        [XmlElement("GRNUM")]
        public string ReceiveCoding { get; set; }

        /// <summary>
        /// 销售订单(VBELN)
        /// </summary>
        [XmlElement("VBELN")]
        public string SaleCoding { get; set; }

        /// <summary>
        /// 销售行项目(VBELP)
        /// </summary>
        [XmlElement("VBELP")]
        public string SaleCodingRow { get; set; }

        /// <summary>
        /// 收货人员(SCANR)
        /// </summary>
        [XmlElement("SCANR")]
        public string Receiver { get; set; }

        /// <summary>
        /// 收货时间(SDATE)
        /// </summary>
        [XmlIgnore]
        public DateTime ReceiveDate { get; set; }

        [XmlElement("SDATE")]
        public string ReceiveDateValue
        {
            get { return ReceiveDate.ToString("yyyyMMdd"); }
            set { ReceiveDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }
    }
}