using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("KpiInstance")]
    public class KpiInstance 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ForceMeasurementDateTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? KpiDefinition { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Settings { get; set; }  

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
