using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("StockSignTurn")]
    public class StockSignTurn 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? OrderStockToLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? LimitToOrderStock { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? OrderStockToOrder { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Quantity { get; set; }  

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
