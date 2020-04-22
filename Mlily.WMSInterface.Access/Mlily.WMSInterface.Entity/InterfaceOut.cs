using System;
using SqlSugar;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.Entity
{
	[SugarTable("InterfaceOut")]
    public class InterfaceOut 
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
		public string CustomerName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CustomerCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MoveType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PickType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Factory { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LineWarehouse { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MlilyLocation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string BillNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string BillItemNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string IsSellStock { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SystemSource { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CostCenter { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string MainAsset { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SellOrganization { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Channel { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string LoadPoint { get; set; }  

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
		public string FromFactory { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ToFactory { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Department { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string FromWarehouse { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ToWarehouse { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string POCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string POName { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ProductGroup { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SellAdress { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SellPerson { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SellPhone { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string PlanType { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Supplier { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? BillTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Logistics { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Unit { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public DateTime? RequireDeliveryTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string Station { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string WorkShopStation { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OffSingle { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string BinNumber { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OldSellCode { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OShopOrder { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ReOrderLogistics { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ReOrderLogisticsNo { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string OperationType { get; set; }  

    }
}
