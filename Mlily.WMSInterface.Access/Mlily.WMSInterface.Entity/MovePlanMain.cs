using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("MovePlanMain")]
    public class MovePlanMain 
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
		public int? OptimisticLockField { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? GCRecord { get; set; }  

    }
}
