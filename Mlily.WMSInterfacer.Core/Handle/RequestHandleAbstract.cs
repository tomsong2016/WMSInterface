using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Handle
{
    public abstract class RequestHandleAbstract
    {
        public abstract BaseResponse Validate(object obj) ;


        public abstract string HandleData(object obj);


        public string Handle(object obj) 
        {
            Validate(obj);

            return HandleData(obj);
        }
    }

}
