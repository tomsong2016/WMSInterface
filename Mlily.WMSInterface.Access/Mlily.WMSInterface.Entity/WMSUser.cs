using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("WMSUser")]
    public class WMSUser 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string FullName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PyCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ModifyPasswordTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? ErrorCount { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsFreeze { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? FreezeTime { get; set; }  

    }
}
