using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PermissionPolicyRole")]
    public class PermissionPolicyRole 
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
		public bool? IsAdministrative { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? CanEditModel { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? PermissionPolicy { get; set; }  

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
