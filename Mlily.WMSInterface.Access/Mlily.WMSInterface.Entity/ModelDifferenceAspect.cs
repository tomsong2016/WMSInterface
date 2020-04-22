using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("ModelDifferenceAspect")]
    public class ModelDifferenceAspect 
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
		public string Xml { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Owner { get; set; }  

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
