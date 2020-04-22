using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    public class SAPClient
    {
        public T Excute<T>(BaseRequest<BaseRequestData> request) where T : BaseResponse 
        {
            return null;
        }
    }
}
