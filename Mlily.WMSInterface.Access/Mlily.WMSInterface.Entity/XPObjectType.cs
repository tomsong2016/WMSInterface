using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("XPObjectType")]
    public class XPObjectType 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="OID")]
		public int OID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TypeName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string AssemblyName { get; set; }  

    }
}
