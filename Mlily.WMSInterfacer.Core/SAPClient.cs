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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string Excute(string data) 
        {
            DateTime startTime = DateTime.Now;
            DateTime endTime = DateTime.Now;
            Regex reg = new Regex("<SERVICEID>(.+)</SERVICEID>");
            Match match = reg.Match(data);
            string value = match.Groups[1].Value;
            Type type = GetAbstractList<RequestHandleAbstract>().Where(k => k.GetCustomAttributes().Any(m => m is ServiceIdAttribute && ((ServiceIdAttribute)m).Name == value))?.FirstOrDefault();
            #region Test
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
            #endregion
            if (type == null)
            {
                return null;
            }

            RequestHandleAbstract handleAbstract = (RequestHandleAbstract)Activator.CreateInstance(type);
            var response =  handleAbstract.Handle(data.Deserialize(RequestTypeFactory.Get(value)));

            endTime = DateTime.Now;
            return XmlSerializerExtent.SerializeXML(response);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private List<Type> GetList<T>()
        {
            return AppDomain
            .CurrentDomain
            .GetAssemblies()
            .SelectMany(item => item.GetTypes())
            .Where(item => item.GetInterfaces().Contains(typeof(T))).ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private List<Type> GetAbstractList<T>() where T:class
        {

            var types = Assembly.GetCallingAssembly().GetTypes();
            var aType = typeof(T);
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
