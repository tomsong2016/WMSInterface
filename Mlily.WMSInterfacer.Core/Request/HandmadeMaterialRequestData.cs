using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class HandmadeMaterialRequestData : BaseRequestData
    {
        /// <summary>
        /// 单据编号(DOCNO)
        /// </summary>
        [XmlElement("DOCNO")]
        public string HandmadeBillCoding { get; set; }

        /// <summary>
        /// 项目编号(ITMNO)
        /// </summary>
        [XmlElement("ITMNO")]
        public string HandmadeBillRow { get; set; }

        /// <summary>
        /// 发出工厂(WERKST)
        /// </summary>
        [XmlElement("WERKST")]
        public string DistributionFactoryCoding { get; set; }

        /// <summary>
        /// 接收工厂(WERKSR)
        /// </summary>
        [XmlElement("WERKSR")]
        public string ReceivingFactoryCoding { get; set; }

        /// <summary>
        /// 部门编号(DEPNO)
        /// </summary>
        [XmlElement("DEPNO")]
        public string DepartmentCoding { get; set; }

        /// <summary>
        /// 发出仓库(LGORT)
        /// </summary>
        [XmlElement("LGORT")]
        public string LocationCoding { get; set; }

        /// <summary>
        /// 接收仓库(LGONR)
        /// </summary>
        [XmlElement("LGONR")]
        public string ReceivingCoding { get; set; }

        [XmlIgnore]
        public DateTime BillDate { get; set; }

        /// <summary>
        /// 单据日期(DOCDA)
        /// </summary>
        [XmlElement("DOCDA")]
        public string BillDateValue
        {
            get { return BillDate.ToString("yyyyMMdd"); }
            set { BillDate = DateTime.ParseExact(value, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture); }
        }

        /// <summary>
        /// 领料类型(MVTYP)
        /// </summary>
        [XmlElement("MVTYP")]
        public string ConsumptionType { get; set; }

        /// <summary>
        /// 订单号(AUFNR)
        /// </summary>
        [XmlElement("AUFNR")]
        public string ProductionOrderCoding { get; set; }

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
        /// 成本中心(KOSTL)
        /// </summary>
        [XmlElement("KOSTL")]
        public string CostCenter { get; set; }

        /// <summary>
        /// 主资产号(ANLN1)
        /// </summary>
        [XmlElement("ANLN1")]
        public string MainAssetCoding { get; set; }

        /// <summary>
        /// 移动类型(BWART)
        /// </summary>
        [XmlElement("BWART")]
        public string MoveType { get; set; }

        /// <summary>
        /// 物料编号(MATNR)
        /// </summary>
        [XmlElement("MATNR")]
        public string MaterialCoding { get; set; }

        /// <summary>
        /// 需求量(BDMNG)
        /// </summary>
        [XmlElement("BDMNG")]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// 实际发货数量(ISQTY)
        /// </summary>
        [XmlElement("ISQTY")]
        public decimal? FactSendQty { get; set; }

        /// <summary>
        /// 批次(CHARGE)
        /// </summary>
        [XmlElement("CHARGE")]
        public string Batch { get; set; }
    }
}
