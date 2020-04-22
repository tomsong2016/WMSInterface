using System;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console.ViewModel
{
    /// <summary>
    /// INT_MM000200011  (SAP向WMS传送MES车间领料需求)
    /// </summary>
    public class WorkshopMaterialContent : ContentAbstract
    {
        /// <summary>
        /// 领料单号(LLDH)
        /// </summary>
        [XmlElement("LLDH")]
        public string PickingCoding { get; set; }

        /// <summary>
        /// 领料单行号(LLHH)
        /// </summary>
        [XmlElement("LLHH")]
        public string PickingRow { get; set; }

        /// <summary>
        /// 领料类型(LLLX)
        /// </summary>
        [XmlElement("LLLX")]
        public string PickingType { get; set; }

        [XmlIgnore]
        public DateTime PickingDate { get; set; }

        /// <summary>
        /// 领料日期(LLRQ)
        /// </summary>
        [XmlElement("LLRQ")]
        public string PickingDateVale
        {
            get { return PickingDate.ToString("yyyyMMdd"); }
            set { PickingDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 领料时间(LLSJ)
        /// </summary>
        [XmlElement("LLSJ")]
        public string PickingTime { get; set; }

        /// <summary>
        /// 领料人(LLR)
        /// </summary>
        [XmlElement("LLR")]
        public string Consultant { get; set; }

        /// <summary>
        /// 工厂(WERKS)
        /// </summary>
        [XmlElement("WERKS")]
        public string FactoryCoding { get; set; }

        /// <summary>
        /// 线边库(XNBK)
        /// </summary>
        [XmlElement("XNBK")]
        public string StorageCoding { get; set; }

        /// <summary>
        /// 工位(GONGW)
        /// </summary>
        [XmlElement("GONGW")]
        public string Workstation { get; set; }

        /// <summary>
        /// 工单(GONGD)
        /// </summary>
        [XmlElement("GONGD")]
        public string WorkOrder { get; set; }

        /// <summary>
        /// 发出库存地点(FCKCDD)
        /// </summary>
        [XmlElement("FCKCDD")]
        public string LocationCoding { get; set; }

        /// <summary>
        /// 订单号(AUFNR)
        /// </summary>
        [XmlElement("AUFNR")]
        public string ProductionOrderCoding { get; set; }

        /// <summary>
        /// 销售订单(KDAUF)
        /// </summary>
        [XmlElement("KDAUF")]
        public string SaleCoding { get; set; }

        /// <summary>
        /// 销售订单项目(KDPOS) 
        /// </summary>
        [XmlElement("KDPOS")]
        public string SaleRow { get; set; }

        /// <summary>
        /// 批次管理标识(XCHPF)
        /// </summary>
        [XmlElement("XCHPF")]
        public string IsBatch {get;set;}

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get; set; }

        /// <summary>
        /// 物料描述(MAKTX)
        /// </summary>
        [XmlElement("MAKTX")]
        public string MaterialDescribe { get; set; }

        /// <summary>
        /// 批号(BATCH)
        /// </summary>
        [XmlElement("BATCH")]
        public string Batch {get;set;}

        /// <summary>
        /// 需求数量(XQSL)
        /// </summary>
        [XmlElement("XQSL")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// 需求数量单位(XQSLDW)
        /// </summary>
        [XmlElement("XQSLDW")]
        public string UnitName { get; set; }

        /// <summary>
        /// 系统来源(XTLY)
        /// </summary>
        [XmlElement("XTLY")]
        public string SystemFrom { get; set; }
    }
}