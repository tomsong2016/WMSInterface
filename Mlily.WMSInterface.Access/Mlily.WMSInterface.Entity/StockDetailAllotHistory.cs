using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("StockDetailAllotHistory")]
    public class StockDetailAllotHistory 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LPN { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Location { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StockDetailID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? TaskType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? StockQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutPlanDetail { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? WaveMain { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StockAllotStatus { get; set; }  

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

    }
}
