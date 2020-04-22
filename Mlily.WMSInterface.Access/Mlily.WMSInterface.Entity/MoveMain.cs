using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("MoveMain")]
    public class MoveMain 
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
		public Guid? EndLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsMoveOut { get; set; }  

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
