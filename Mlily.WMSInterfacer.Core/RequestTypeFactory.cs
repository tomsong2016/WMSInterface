﻿using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mlily.WMSInterfacer.Core
{
    public class RequestTypeFactory
    {
        public static Type Get(string data)
        {
            switch (data)
            {
                case "INT_MM000200035":
                    return typeof(DefaultRequestModel<InspectionReportRequestData, InspectionReportResponse>);
                case "INT_MM000200011":
                    return typeof(DefaultRequestModel<WorkshopMaterialRequestData, WorkshopMaterialResponse>);
                case "INT_MM000200006":
                    return typeof(DefaultRequestModel<DeliveryRequestData, DeliveryResponse>);
                case "INT_MM000200007":
                    return typeof(DefaultRequestModel<PurchasingOrderRequestData, PurchasingOrderResponse>);
                default:
                    return null;
            }
        }
    }
}
