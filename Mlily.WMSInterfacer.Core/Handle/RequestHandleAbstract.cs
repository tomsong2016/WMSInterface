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


        public abstract BaseResponse HandleDataExtent(object obj);

        public BaseResponse Handle(object obj) 
        {
            var response =  Validate(obj);
            if (response.IsSuccess)
            {
                response = HandleDataExtent(obj);
            }

            return response;
        }
    }

}
