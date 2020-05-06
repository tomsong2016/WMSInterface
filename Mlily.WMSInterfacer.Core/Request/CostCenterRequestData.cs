using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Request
{
    public class CostCenterRequestData : BaseRequestData
    {
        //<BUKRS>CN01</BUKRS>
        //           <KOSTL>CN01040001</KOSTL>
        //           <LTEXT>总经办</LTEXT>

        /// <summary>
        /// 公司编码(BUKRS)
        /// </summary>
        public string CompanyCoding { get; set; }

        /// <summary>
        /// 成本中心(BUKRS)
        /// </summary>
        public string CostCenter { get; set; }

        /// <summary>
        /// 成本中心名称(LTEXT)
        /// </summary>
        public string CostCenterName { get; set; }
    }
}
