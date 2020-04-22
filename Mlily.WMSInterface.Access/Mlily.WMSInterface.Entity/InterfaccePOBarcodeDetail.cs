using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InterfaccePOBarcodeDetail")]
    public class InterfaccePOBarcodeDetail 
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
		public string MaterialID { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MaterialCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MaterialName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Lot { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PlanQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public bool? IsPostback { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? PostbackTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PostbackResult { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public long? Index { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? QuantityPerPack { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SequenceNum { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Barcode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string TaskNo { get; set; }  

    }
}
