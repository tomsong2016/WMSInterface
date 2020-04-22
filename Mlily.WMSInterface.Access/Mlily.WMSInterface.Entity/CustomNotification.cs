using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("CustomNotification")]
    public class CustomNotification 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Subject { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? DueDate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? AlarmTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsPostponed { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public double? RemindIn { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AssignedRole { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OpenInterfaceStr { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Co { get; set; }  

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
