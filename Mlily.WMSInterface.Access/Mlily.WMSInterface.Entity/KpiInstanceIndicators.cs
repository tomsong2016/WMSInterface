using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("KpiScorecardScorecards_KpiInstanceIndicators")]
    public class KpiInstanceIndicators 
    {

		/// <summary>
		///  
		/// </summary>
		public Guid? Indicators { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Scorecards { get; set; }  

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="OID")]
		public Guid OID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

    }
}
