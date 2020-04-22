using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PermissionPolicyUserUsers_PermissionPolicyRoleRoles")]
    public class PermissionPolicyRoleRoles 
    {

		/// <summary>
		///  
		/// </summary>
		public Guid? Roles { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Users { get; set; }  

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="OID")]
		public Guid OID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

    }
}
