using System;
using System.Collections.Generic;
using System.Linq;
using Mlily.WMSInterface.Data;
using Mlily.WMSInterface.Entity;
using Mlily.WMSInterface.ServiceModel;
using Nelibur.ObjectMapper;

namespace Mlily.WMSInterface.Service
{
    public class InterfacePlatformService :  DBContext<InterfacePlatform>
    {
        public InterfacePlatformService()
        {
            TinyMapper.Bind<InterfacePlatformServiceModel, InterfacePlatform>();
            TinyMapper.Bind<InterfacePlatform, InterfacePlatformServiceModel>();
        }

        public InterfacePlatformServiceModel GetModel()
        {
            return null;
        }

        public List<InterfacePlatformServiceModel> GetNowList()
        {
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            var list = GetList(e => e.CreateTime >= now);

            if (list != null)
            {
                return list.Select(TinyMapper.Map<InterfacePlatformServiceModel>).ToList();
            }

            return null;
        }
    }
}