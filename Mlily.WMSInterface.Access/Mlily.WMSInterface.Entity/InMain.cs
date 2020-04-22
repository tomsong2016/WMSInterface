using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InMain")]
    public class InMain 
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
		public string LPN { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? LPNType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Location { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsComplete { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CompleteTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ReceiptStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InGroup { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StackUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? StackTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? CheckUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CheckTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? PutawayUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? PutawayTime { get; set; }  

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
		public Guid? Region { get; set; }  

    }
}
