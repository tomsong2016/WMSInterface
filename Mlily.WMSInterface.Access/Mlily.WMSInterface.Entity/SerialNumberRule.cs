using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("SerialNumberRule")]
    public class SerialNumberRule 
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
		public string DateIdentifier { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Prefix { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? Length { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public long? Maximum { get; set; }  

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
