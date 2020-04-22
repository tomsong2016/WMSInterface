using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("VehicleOutMain")]
    public class VehicleOutMain 
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
		public string QueueNum { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string VehicleNum { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string DrivingNum { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PhoneNum { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? InTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CallTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? CompleteTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? OutTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Platform { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? OutInDoor { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? VehicleStatus { get; set; }  

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
