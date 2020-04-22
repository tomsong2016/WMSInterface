using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("OutDoorAllot")]
    public class OutDoorAllot 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutPlanDetail { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Area { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? AllotQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PickingQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ProcessStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutInDoor { get; set; }  

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
