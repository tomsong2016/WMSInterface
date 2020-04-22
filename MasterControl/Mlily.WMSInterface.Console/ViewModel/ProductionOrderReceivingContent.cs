using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM002100007 生产订单收货 or INT_MM002100006 转料
    /// or INT_MM002100008 销售订单库存转签 or INT_MM002100004 库存冻结解冻 or INT_MM002100005 库存报废
    /// 可以包括【INT_MM002100014 无采购订单收货 OR INT_MM002100011 WMS 向SAP发送采购订单收货后退货(非退货订单) OR INT_MM002100012 WMS 向SAP发送交货单发货过账冲销 WithoutPurchasingContent】
    /// </summary>
    public class ProductionOrderReceivingContent : ContentAbstract
    {
        [XmlIgnore]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// 凭证中的凭证日期(BLDAT)
        /// </summary>
        [XmlElement("BLDAT")]
        public string BillDateValue
        {
            get { return BillDate.ToString("yyyyMMdd"); }
            set { BillDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        [XmlIgnore]
        public DateTime BillPastingDate { get; set; }

        /// <summary>
        /// 凭证中的过帐日期
        /// </summary>
        [XmlElement("BUDAT")]
        public string BillPastingDateValue
        {
            get { return BillPastingDate.ToString("yyyyMMdd"); }
            set { BillPastingDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 移动类型(库存管理BWART)
        /// </summary>
        [XmlElement("BWART")]
        public string  MoveType  {get;set;}

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get;set;}

        /// <summary>
        /// 工厂(WERKS)
        /// </summary>
        [XmlElement("WERKS")]
        public string  FactoryCoding  {get;set;}

        /// <summary>
        /// 库存地点(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string LocationCoding { get;set;}

        /// <summary>
        /// 成本中心(KOSTL)
        /// </summary>
        [XmlElement("KOSTL")]
        public string CostCenter { get;set;}

        /// <summary>
        /// 移动原因(GRUND)
        /// </summary>
        [XmlElement("GRUND")]
        public string  MoveReason  {get;set;}

        /// <summary>
        /// 订单号(AUFNR)
        /// </summary>
        [XmlElement("AUFNR")]
        public string ProductionOrderCoding { get;set;}

        /// <summary>
        /// 收货/发货物料(UMMAT)
        /// </summary>
        [XmlElement("UMMAT")]
        public string ReceivingMaterialCoding { get;set;}

        /// <summary>
        /// 收货工厂(UMWRK)
        /// </summary>
        [XmlElement("UMWRK")]
        public string ReceivingFactoryCoding { get;set;}

        /// <summary>
        /// 收货/发货库存地点(UMLGO)
        /// </summary>
        [XmlElement("UMLGO")]
        public string ReceivingCoding { get;set;}

        /// <summary>
        /// 数量(MENGE)
        /// </summary>
        [XmlElement("MENGE")]
        public decimal Quantity { get;set;}

        /// <summary>
        /// 基本计量单位(MEINS)
        /// </summary>
        [XmlElement("MEINS")]
        public string UnitName { get; set; }

        /// <summary>
        /// 销售凭证(VBELN) 
        /// </summary>
        [XmlElement("VBELN")]
        public string SaleCoding { get; set; }

        /// <summary>
        /// 销售凭证项目(POSNR) 
        /// </summary>
        [XmlElement("POSNR")]
        public string SaleRow { get; set; }

        /// <summary>
        /// 销售凭证项目(TOVBELN) 
        /// </summary>
        [XmlElement("TOVBELN")]
        public string ToSaleCoding { get; set; }

        /// <summary>
        /// 销售凭证项目(TOPOSNR) 
        /// </summary>
        [XmlElement("TOPOSNR")]
        public string ToSaleRow { get; set; }

        /// <summary>
        /// 批次(CHARGE)
        /// </summary>
        [XmlElement("CHARGE")]
        public string Batch { get; set; }
    }
}