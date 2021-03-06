using System;

/// <summary>
///  
/// </summary>
namespace Mlily.WMSInterface.ServiceModel
{
    public class InterfacePlatformServiceModel 
    {

		/// <summary>
		///  
		/// </summary>
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
		public DateTime? CreateTime { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string CreateUser { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string SendMessage { get; set; }  

		/// <summary>
		///  
		/// </summary>
		public string ReceivingMessage { get; set; }  

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
