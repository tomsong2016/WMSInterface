using Mlily.WMSInterfacer.Core.Handle;
using Mlily.WMSInterfacer.Core.Request;
using Mlily.WMSInterfacer.Core.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Mlily.WMSInterfacer.Core
{
    public class SAPClient:IClient
    {
        public string Excute(string data) 
        {
            Regex reg = new Regex("<SERVICEID>(.+)</SERVICEID>");
            Match match = reg.Match(data);
            string value = match.Groups[1].Value;
            Type type = GetAbstractList().Where(k => k.GetCustomAttributes().Any(m => m is ServiceIdAttribute && ((ServiceIdAttribute)m).Name == value))?.FirstOrDefault();

            //Type type = GetAbstractList().Where(k => k.GetCustomAttributes().Where(m => m is ServiceIdAttribute && ((ServiceIdAttribute)m).Name == value)).FirstOrDefault;
            //foreach (var item in GetAbstractList(k=>k.GetCustomAttributes().Where(m => m is ServiceIdAttribute && ((ServiceIdAttribute)m).Name == value)))
            //{
            //    bool selected = false;
            //    var attributeitem = item.GetCustomAttributes().Where(m => m is ServiceIdAttribute && ((ServiceIdAttribute)m).Name == value);
            //    foreach (var itemAttribute in attributeitem)
            //    {
            //        var attribute = (ServiceIdAttribute)itemAttribute;

            //        if (attribute.Name == value)
            //        {
            //            selected = true;
            //            break;
            //        }
            //    }

            //    if (selected) 
            //    {
            //        type = item;
            //        break;
            //    }
            //}

            if (type == null)
            {
                return null;
            }

            RequestHandleAbstract handleAbstract = (RequestHandleAbstract)Activator.CreateInstance(type);
            return handleAbstract.Handle(data.Deserialize(RequestTypeFactory.Get(value)));
        }

        //private List<Type> GetList()
        //{
        //    return AppDomain
        //    .CurrentDomain
        //    .GetAssemblies()
        //    .SelectMany(item => item.GetTypes())
        //    .Where(item => item.GetInterfaces().Contains(typeof(ITest))).ToList();
        //}


        private List<Type> GetAbstractList()
        {

            var types = Assembly.GetCallingAssembly().GetTypes();
            var aType = typeof(RequestHandleAbstract);
            List<Type> alist = new List<Type>();
            foreach (var type in types)
            {
                var baseType = type.BaseType;  //获取基类
                while (baseType != null)  //获取所有基类
                {
                    if (baseType.Name == aType.Name)
                    {
                        alist.Add(type);
                        break;
                    }
                    else
                    {
                        baseType = baseType.BaseType;
                    }
                }

            }

            return alist;
        }
    }
}
