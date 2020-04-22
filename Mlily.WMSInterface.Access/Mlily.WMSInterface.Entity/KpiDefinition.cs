using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("KpiDefinition")]
    public class KpiDefinition 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TargetObjectType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? Changed { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? KpiInstance { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Name { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? Active { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Criteria { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Expression { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public double? GreenZone { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public double? RedZone { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Range { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? Compare { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string RangeToCompare { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? MeasurementFrequency { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? MeasurementMode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? Direction { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ChangedOn { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SuppressedSeries { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? EnableCustomizeRepresentation { get; set; }  

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
