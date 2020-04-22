using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("Location")]
    public class Location 
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
		public Guid? Area { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Laneway { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Row { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Vertical { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Layer { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? LocationType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ABCType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? WorkArea { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Length { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Width { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Height { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Weight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Volume { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Capacity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string InPriority { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutPriority { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LocationAlias { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Group { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PhysicArea { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsOpen { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? AllowMix { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? AllowMixLot { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? AllowPick { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? RemoveLPN { get; set; }  

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
		public int? OptimisticLockField { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? GCRecord { get; set; }  

    }
}
