using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PermissionPolicyTypePermissionsObject")]
    public class PermissionPolicyTypePermissionsObject 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Role { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TargetType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? ReadState { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? WriteState { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? CreateState { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? DeleteState { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? NavigateState { get; set; }  

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
