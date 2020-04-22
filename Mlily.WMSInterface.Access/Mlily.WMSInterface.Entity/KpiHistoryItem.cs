using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("KpiHistoryItem")]
    public class KpiHistoryItem 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? KpiInstance { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? RangeStart { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? RangeEnd { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public double? Value { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

    }
}
