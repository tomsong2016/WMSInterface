using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PermissionPolicyUser")]
    public class PermissionPolicyUser 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string StoredPassword { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? ChangePasswordOnFirstLogon { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string UserName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsActive { get; set; }  

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
		public int? ObjectType { get; set; }  

    }
}
