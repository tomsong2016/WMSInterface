using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM000200007 SAP采购订单数据传送
    /// </summary>
    public class PurchasingOrderContent:ContentAbstract
    {
        /// <summary>
        /// 采购凭证编号(EBELN)
        /// </summary>
        [XmlElement("EBELN")]
        public string POCoding { get; set; }

        /// <summary>
        /// 采购凭证的项目编号(EBELP)
        /// </summary>
        [XmlElement("EBELP")]
        public string PORow { get; set; }

        /// <summary>
        /// 公司代码(BUKRS)
        /// </summary>
        [XmlElement("BUKRS")]
        public string CompanyCoding { get; set; }

        /// <summary>
        /// 采购凭证类别(BSTYP)
        /// </summary>
        [XmlElement("BSTYP")]
        public string POCategory { get; set; }

        /// <summary>
        /// 采购凭证类型(BSART)
        /// </summary>
        [XmlElement("BSART")]
        public string POType { get; set; }

        [XmlIgnore]
        public DateTime CreteTime { get; set; }

        /// <summary>
        /// 记录建立日期(AEDAT)
        /// </summary>
        [XmlElement("AEDAT")]
        public string CreteTimeValue
        {
            get { return CreteTime.ToString("yyyyMMdd"); }
            set { CreteTime = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 创建对象的人员名称(ERNAM)
        /// </summary>
        [XmlElement("ERNAM")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 货币码(WAERS)
        /// </summary>
        [XmlElement("WAERS")]
        public string CurrencyCoding { get; set; }

        /// <summary>
        /// 供应商编号(LIFNR)
        /// </summary>
        [XmlElement("LIFNR")]
        public string SupplierCoding { get; set; }

        /// <summary>
        /// 供应商名称(NAME1)
        /// </summary>
        [XmlElement("NAME1")]
        public string Supplier { get; set; }

        /// <summary>
        /// 采购组织(EKORG)
        /// </summary>
        [XmlElement("EKORG")]
        public string POOrganization { get; set; }

        /// <summary>
        /// 采购组(EKGRP)
        /// </summary>
        [XmlElement("EKGRP")]
        public string POGroup { get; set; }

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterielCoding { get; set; }

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
        /// 采购订单数量(MENGE)
        /// </summary>
        [XmlElement("MENGE")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// 采购订单计量单位(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string UnitName { get; set; }

        /// <summary>
        /// 采购凭证中的项目类别(PSTYP)
        /// </summary>
        [XmlElement("PSTYP")]
        public string PORowType { get; set; }

        /// <summary>
        /// 销售和分销凭证号(VBELN)
        /// </summary>
        [XmlElement("VBELN")]
        public string SaleCoding { get; set; }

        /// <summary>
        /// 销售单据项目(VBELP)
        /// </summary>
        [XmlElement("VBELP")]
        public string SaleRow { get; set; }

        [XmlIgnore]
        public DateTime DeliveryDateTime { get; set; }

        /// <summary>
        /// 交货日期(EEIND)
        /// </summary>
        [XmlElement("EEIND")]
        public string DeliveryDateTimeValue
        {
            get { return DeliveryDateTime.ToString("yyyyMMdd"); }
            set { DeliveryDateTime = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        //<UEBTO>0.0</UEBTO>
        //<UNTTO>0.0</UNTTO>
        //<EEIND>20190809</EEIND>
    }
}