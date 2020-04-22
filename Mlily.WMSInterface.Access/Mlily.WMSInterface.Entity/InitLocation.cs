using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InitLocation")]
    public class InitLocation 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

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
		public Guid? ABCType { get; set; }  

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
		public bool? AllowPick { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? RemoveLPN { get; set; }  

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
