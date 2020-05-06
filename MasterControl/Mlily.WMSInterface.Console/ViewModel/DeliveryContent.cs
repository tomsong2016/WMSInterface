using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM000200006 SAP销售交货单传送
    /// </summary>
    public class DeliveryContent : ContentAbstract
    {
        /// <summary>
        /// 交货单(VBELN)
        /// </summary>
        [XmlElement("VBELN")]
        public string DeliveryOrderCoding     {get;set;}

        /// <summary>
        /// 交货项目(POSNR)
        /// </summary>
        [XmlElement("POSNR")]
        public string DeliveryOrderRow { get;set;}

        /// <summary>
        /// 交货类型(LFART)
        /// </summary>
        [XmlElement("LFART")]
        public string DeliveryType { get;set;}

        /// <summary>
        /// 客户编号(KUNNR)
        /// </summary>
        [XmlElement("KUNNR")]
        public string SupplierCoding { get;set;}

        /// <summary>
        /// 销售组织(VKORG)
        /// </summary>
        [XmlElement("VKORG")]
        public string SalesOrganization  {get;set;}

        /// <summary>
        /// 分销渠道(VTWEG)
        /// </summary>
        [XmlElement("VTWEG")]
        public string DistributionChannel {get;set;}

        /// <summary>
        /// 产品组(SPART)
        /// </summary>
        [XmlElement("SPART")]
        public string ProductGroup {get;set;}

        /// <summary>
        /// 装运点/接收点(VSTEL)
        /// </summary>
        [XmlElement("VSTEL")]
        public string ShippingOrReceivingPoint { get;set;}

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get;set;}

        /// <summary>
        /// 工厂(WERKS)
        /// </summary>
        [XmlElement("WERKS")]
        public string FactoryCoding { get;set;}

        /// <summary>
        /// 库存地点(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string StockLocationCoding { get;set;}

        /// <summary>
        /// 交货量(LFIMG)
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