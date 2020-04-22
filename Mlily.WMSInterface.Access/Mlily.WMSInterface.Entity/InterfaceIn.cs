using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InterfaceIn")]
    public class InterfaceIn 
    {

		/// <summary>
		///  
		/// </summary>
		[SugarColumn(IsPrimaryKey = true,  ColumnName ="ID")]
		public Guid ID { get; set; }  

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
		public string OperationType { get; set; }  

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
		public string SupplierName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SupplierCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CompanyCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Factory { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MlilyLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MainAsset { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string BillNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CostCenter { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OutName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PlanType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Unit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OrderType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SystemStatus { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string DeliveryCompleted { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string InvalidLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? OrderStartTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? OrderDueTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? ReceivedQuantity { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LowerLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? OverLimit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Receiving { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SpareArea { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ReceivingUnlimited { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? LessPercentage { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public decimal? OverPercentage { get; set; }  

    }
}
