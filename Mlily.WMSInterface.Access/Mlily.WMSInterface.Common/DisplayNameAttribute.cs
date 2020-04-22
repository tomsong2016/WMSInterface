using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Mlily.WMSInterface.Common
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class)]
    public class DisplayNameAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public bool Show { get; set; }

        public DisplayNameAttribute(string displayName)
        {
            this.DisplayName = displayName;
            this.Show = true;
        }

        public DisplayNameAttribute(string displayName, bool show)
        {
            this.DisplayName = displayName;
            this.Show = show;
        }
    }

    public static class AttributeExtendMethod
    {
        public static string GetRemark(this Enum eValue)
        {
            Type type = eValue.GetType();

            // 获取字段信息（先找到字段）
            FieldInfo field = type.GetField(eValue.ToString());

            // 获取特性信息 （找到特性包括重复）
            var attrs = field.GetCustomAttributes(typeof(DisplayNameAttribute), false);
            var attr = (DisplayNameAttribute)attrs.FirstOrDefault(e => e is DisplayNameAttribute);

            if (attr != null && attr.Show)
            {
                return attr.DisplayName;
            }

            return null;
        }

        public static List<KeyValuePair<string, string>> GetAllRemark(this Enum value)
        {
            Type type = value.GetType();
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();

            foreach (var val in Enum.GetValues(type))
            {
                result.Add(new KeyValuePair<string, string>(((int)val).ToString(), ((Enum)val).GetRemark()));
            }

            return result;
        }

        public static List<KeyValuePair<string, string>> GetAllRemark<T>() where T : struct
        {
            Type type = typeof(T);
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();
            foreach (var val in Enum.GetValues(type))
            {
                result.Add(new KeyValuePair<string, string>(((int)val).ToString(), ((Enum)val).GetRemark()));
            }

            return result;
        }

        public static List<KeyValuePair<string, string>> GetAllRemark(this Type type)
        {
            //Type type = value.GetType();
            List<KeyValuePair<string, string>> result = new List<KeyValuePair<string, string>>();

            foreach (var val in Enum.GetValues(type))
            {
                if (((Enum)val).GetRemark() != null)
                {
                    result.Add(new KeyValuePair<string, string>(((int)val).ToString(), ((Enum)val).GetRemark()));
                }
            }

            return result;
        }


        //public static string GetClassRemark<T>(this T t) where T : class
        //{
        //    Type type = t.GetType();

        //    var fileInfos = type.GetFields();

        //    var att = (RemarkAttribute)type.GetCustomAttributes(typeof(RemarkAttribute), false).FirstOrDefault();
        //    return att == null ? type.Name : att.Remark;
        //}
    }
}