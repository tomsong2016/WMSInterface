using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InterfaceMaterial")]
    public class InterfaceMaterial 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="ID")]
		public Guid ID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string NID { get; set; }  

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
		public DateTime? CreateTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CreateUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public int? IsProcess { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ProcessTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ProcessResult { get; set; }  

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
		public bool? IsModify { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? DeleteFlag { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? ModifyTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Unit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MaterialType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Weight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string WeightUnit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsLot { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsSN { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OldCode { get; set; }  

    }
}
