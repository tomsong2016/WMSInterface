using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("OutPlanMain")]
    public class OutPlanMain 
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
		public Guid? Supplier { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Consignee { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SourceDocument { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ERPCode { get; set; }  

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
		public Guid? PlanType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? IsProcess { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ProcessStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AuditUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? AuditTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AuditResult { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string RejectionReason { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AuditSecondUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? AuditSecondTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AuditSecondResult { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string RejectionSecondReason { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsAudited { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Priority { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Region { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? WaveMain { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutInDoor { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? PlanIFStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? VehicleOutMain { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutPlanStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? RequireShipmentTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? RequireDeliveryTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AllotUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? AllotTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? EndSubWarehouse { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? EndLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LogisticsNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LogisticsType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LogisticsMan { get; set; }  

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
		public string WorkShopStation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OffSingle { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string JoinIdent { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string AlternativeRegion { get; set; }  

    }
}
