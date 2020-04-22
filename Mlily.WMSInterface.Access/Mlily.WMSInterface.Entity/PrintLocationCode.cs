using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PrintLocationCode")]
    public class PrintLocationCode 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

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
