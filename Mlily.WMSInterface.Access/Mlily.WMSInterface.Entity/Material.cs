using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("Material")]
    public class Material 
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
		public string Spec { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Brand { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? UpperLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LowerLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? SafeStock { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? UsefulLife { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? WarnMonth { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? ReviewMonth { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? TemperatureStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? StoreStrategy { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? PickStrategy { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? AuditStrategy { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsLotManage { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsBarcodeManage { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? MaterialType { get; set; }  

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
		public Guid? LotAttributeRule { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsDefault { get; set; }  

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
		public string OldCode { get; set; }  

    }
}
