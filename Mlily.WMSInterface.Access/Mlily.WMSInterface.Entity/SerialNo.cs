using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("SerialNo")]
    public class SerialNo 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="sCode")]
		public string SCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SQZ { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SValue { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? OptimisticLockField { get; set; }  

    }
}
