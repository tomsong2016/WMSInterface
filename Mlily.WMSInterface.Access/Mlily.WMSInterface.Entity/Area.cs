using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("Area")]
    public class Area 
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
		public Guid? Region { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AreaType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? MlilyLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? TemperatureStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsDefault { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? InTransitionLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutTransitionLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? X { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? Y { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? Z { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? GCRecord { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? SortingLocation { get; set; }  

    }
}
