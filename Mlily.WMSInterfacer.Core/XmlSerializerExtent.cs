using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Mlily.WMSInterfacer.Core
{
    public static class XmlSerializerExtent
    {
        public static object Deserialize(this string xml, Type type)
        {
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(type);
                    return xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                //logger.Error(e, "方法出错：Deserialize");
                return null;
            }
        }

        public static object Deserialize(this Stream stream, Type type)
        {
            XmlSerializer xmldes = new XmlSerializer(type);
            return xmldes.Deserialize(stream);
        }

        public static string Serializer(this object obj, Type type)
        {
            MemoryStream Stream = new MemoryStream();
            XmlSerializer xml = new XmlSerializer(type);
            try
            {
                //序列化对象
                xml.Serialize(Stream, obj);
            }
            catch (InvalidOperationException e)
            {
                throw;
            }
            Stream.Position = 0;
            StreamReader sr = new StreamReader(Stream);
            string str = sr.ReadToEnd();
            sr.Dispose();
            Stream.Dispose();
            return str;
        }

        /// <summary>  
        /// 反序列化XML为类实例  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="xmlObj"></param>  
        /// <returns></returns>  
        public static T DeserializeXML<T>(string xmlObj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xmlObj))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

        /// <summary>  
        /// 序列化类实例为XML  
        /// </summary>  
        /// <typeparam name="T"></typeparam>  
        /// <param name="obj"></param>  
        /// <returns></returns>  
        public static string SerializeXML<T>(T obj)
        {
            using (StringWriter writer = new StringWriter())
            {
                new XmlSerializer(obj.GetType()).Serialize((TextWriter)writer, obj);
                return writer.ToString();
            }
        }

        public static string AddHead(this string content)
        {
            if (content.StartsWith("<?xml"))
            {
                return content;
            }

            return $"<?xml version='1.0' encoding='utf-8'?>{content}";
        }
    }
}
