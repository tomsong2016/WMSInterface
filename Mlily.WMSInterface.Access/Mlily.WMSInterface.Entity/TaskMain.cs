using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("TaskMain")]
    public class TaskMain 
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
		public Guid? TaskType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LPN { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TaskStep { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string InStation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? LPNType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? TaskID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Region { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StartLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? EndLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? StartTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CompleteTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? ProblemType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Priority { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SerialNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? TaskStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutTo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? AutoComplete { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Device { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? DeviceNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutDeviceNo { get; set; }  

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
