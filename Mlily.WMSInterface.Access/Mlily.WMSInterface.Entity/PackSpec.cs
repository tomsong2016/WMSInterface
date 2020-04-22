using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("PackSpec")]
    public class PackSpec 
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
		public Guid? Material { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? Unit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public Guid? UnitAuxiliary { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? ConversionRateAuxiliary { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? ConversionRate { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PackQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LPNQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Length { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Width { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Height { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PalletLength { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PalletWidth { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? PalletHeight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Volume { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? BoxVolume { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? BoxWeight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? BoxNetWeight { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Ti { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? Hi { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsDefault { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? RobotSignal { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public byte[] LargePhoto { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public byte[] Photo { get; set; }  

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
