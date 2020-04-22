using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("ReportDataV2")]
    public class ReportDataV2 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ObjectTypeName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public byte[] Content { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Name { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ParametersObjectTypeName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsInplaceReport { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PredefinedReportType { get; set; }  

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
