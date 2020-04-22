using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InPlanManage")]
    public class InPlanManage 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ArrivalStartTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ArrivalDueTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InPlanStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InType { get; set; }  

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
