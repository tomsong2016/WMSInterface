using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("OutInDoor")]
    public class OutInDoor 
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
		public string Remark1 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark2 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark3 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark4 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Remark5 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index1 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index2 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Index3 { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutInType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutInMode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Area { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Customize { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PhysicArea { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsUse { get; set; }  

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
