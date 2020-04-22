using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("Laneway")]
    public class Laneway 
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
		public Guid? Device { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Area { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ShelfType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LanewayNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LimitLPN1 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LimitLPN2 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LimitLPN3 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LimitLPN4 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Ratio { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? SwitchProperty { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? AllowLPN { get; set; }  

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
