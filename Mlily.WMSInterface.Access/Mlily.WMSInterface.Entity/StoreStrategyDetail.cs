using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("StoreStrategyDetail")]
    public class StoreStrategyDetail 
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
		public Guid? StoreStrategyMain { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Area { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? StartRow { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? EndRow { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? StartLayer { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? EndLayer { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? StartVertical { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? EndVertical { get; set; }  

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
