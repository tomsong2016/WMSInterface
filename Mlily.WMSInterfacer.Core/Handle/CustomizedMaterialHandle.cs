﻿using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core.Handle
{
    [ServiceId("INT_MM000200010")]
    public class CustomizedMaterialHandle : RequestHandleAbstract
    {
        public override string HandleData(object obj)
        {
            throw new NotImplementedException();
        }

        public override BaseResponse HandleDataExtent(object obj)
        {
            throw new NotImplementedException();
        }

        public override BaseResponse Validate(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
