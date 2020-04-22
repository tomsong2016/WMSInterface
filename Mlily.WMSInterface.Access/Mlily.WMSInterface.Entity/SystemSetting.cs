using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("SystemSetting")]
    public class SystemSetting 
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
		public string Company { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Ratio { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? OutQuantityLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? LittlePick { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? CrossAreaOut { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? TaskAutoRecovery { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? EnableInGroup { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? EnableQC { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? EnableDestinationAllot { get; set; }  

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
