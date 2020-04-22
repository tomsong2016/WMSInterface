using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PermissionPolicyMemberPermissionsObject")]
    public class PermissionPolicyMemberPermissionsObject 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="Oid")]
		public Guid Oid { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Members { get; set; }  

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
		public string Criteria { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? TypePermissionObject { get; set; }  

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
