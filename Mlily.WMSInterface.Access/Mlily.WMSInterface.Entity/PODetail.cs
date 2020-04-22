using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PODetail")]
    public class PODetail 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Name { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Code { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PyCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? DeleteFlag { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? CreateUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CreateTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ModifyUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ModifyTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Warehouse { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark1 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark2 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark3 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark4 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark5 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index1 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index2 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index3 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Material { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? PackSpec { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Supplier { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Manufactory { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Lot { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? QCStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ProduceDate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SerialNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string POMainCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PODetailCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Color { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Size { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ExpirationDate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ContractNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TaskNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Owner { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StockArea { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Consignee { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StockForm { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ProduceLine { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string InnerBatch { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string BVN { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ProductionDate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SupplierLot { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Manufacturer { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Barcode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Quantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LotAttribute { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? ConversionRate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PlanQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PlanQuantityAuxiliary { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? QuantityAuxiliary { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Volume { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Weight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? NetWeight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Amount { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CertificateID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InPlanDetail { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? POMain { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ProcessStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? GCRecord { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Reference { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SaleOrderNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SaleOrderLine { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SaleOrder { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PostingQuantity { get; set; }  

    }
}
