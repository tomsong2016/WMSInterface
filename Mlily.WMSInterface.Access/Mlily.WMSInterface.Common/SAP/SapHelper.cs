using SAP.Middleware.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mlily.WMSInterface.Common.SAP
{
    public class SapHelper
    {

        public static string SendToSAP(string requestXML)
        {
            try
            {
                string strRes = string.Empty;//res.ZfmServiceResponse.EvResponse;
                RfcConfigParameters rfcPar = new RfcConfigParameters();
#if DEBUG
                rfcPar.Add(RfcConfigParameters.Name, "MSQ");
                rfcPar.Add(RfcConfigParameters.AppServerHost, "192.168.4.39");
                rfcPar.Add(RfcConfigParameters.Client, "500");
#else
                rfcPar.Add(RfcConfigParameters.Name, "MSP");
                rfcPar.Add(RfcConfigParameters.AppServerHost, "192.168.4.40");
                rfcPar.Add(RfcConfigParameters.Client, "800");
#endif

                rfcPar.Add(RfcConfigParameters.User, "INTUSER");
                rfcPar.Add(RfcConfigParameters.Password, "90-=op[]");
                rfcPar.Add(RfcConfigParameters.SystemNumber, "00");
                rfcPar.Add(RfcConfigParameters.Language, "ZH");
                RfcDestination dest = RfcDestinationManager.GetDestination(rfcPar);
                RfcRepository rfcrep = dest.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZFM_SERVICE_DRP");
                myfun.SetValue("IV_REQUEST", requestXML);//SAP里面的传入参数
                myfun.Invoke(dest);
                // IRfcTable lrfTable = myfun.GetTable("");
                strRes = myfun.GetString("EV_RESPONSE");
                return strRes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public static string SendToSAP500(string requestXML)
        {
            try
            {

                string strRes = "";//res.ZfmServiceResponse.EvResponse;
                RfcConfigParameters rfcPar = new RfcConfigParameters();
                rfcPar.Add(RfcConfigParameters.Name, "MSQ");
                rfcPar.Add(RfcConfigParameters.AppServerHost, "192.168.4.39");
                rfcPar.Add(RfcConfigParameters.Client, "500");
                rfcPar.Add(RfcConfigParameters.User, "INTUSER");
                rfcPar.Add(RfcConfigParameters.Password, "90-=op[]");
                rfcPar.Add(RfcConfigParameters.SystemNumber, "00");
                rfcPar.Add(RfcConfigParameters.Language, "ZH");
                RfcDestination dest = RfcDestinationManager.GetDestination(rfcPar);
                RfcRepository rfcrep = dest.Repository;
                IRfcFunction myfun = null;
                myfun = rfcrep.CreateFunction("ZFM_SERVICE_DRP");
                myfun.SetValue("IV_REQUEST", requestXML);//SAP里面的传入参数
                myfun.Invoke(dest);
                // IRfcTable lrfTable = myfun.GetTable("");
                strRes = myfun.GetString("EV_RESPONSE");
                return strRes;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}