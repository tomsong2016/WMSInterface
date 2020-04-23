using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
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
                MemoryStream ms = new MemoryStream();
                //设置序序化XML格式
                XmlWriterSettings xws = new XmlWriterSettings();
                xws.Indent = true;
                xws.OmitXmlDeclaration = true;
                xws.Encoding = Encoding.UTF8;
                XmlWriter xtw = XmlTextWriter.Create(ms, xws);
                //去掉要结点的 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" 属性
                XmlSerializerNamespaces _namespaces = new XmlSerializerNamespaces(
                    new XmlQualifiedName[] {
                        new XmlQualifiedName(string.Empty, "aa")
                 });


                //序列化对象
                xml.Serialize(Stream, obj, _namespaces);
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


            //XmlSerializer xs = new XmlSerializer(obj.GetType());
            //MemoryStream ms = new MemoryStream();
            ////设置序序化XML格式
            //XmlWriterSettings xws = new XmlWriterSettings();
            //xws.Indent = true;
            //xws.OmitXmlDeclaration = true;
            //xws.Encoding = Encoding.UTF8;
            //XmlWriter xtw = XmlTextWriter.Create(ms, xws);
            ////去掉要结点的 xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" 属性
            //XmlSerializerNamespaces _namespaces = new XmlSerializerNamespaces(
            //    new XmlQualifiedName[] {
            //            new XmlQualifiedName(string.Empty, "aa")
            // });
            //xs.Serialize(xtw, obj, _namespaces);
            //ms.Position = 0;
            //XmlDocument xmlDoc = new XmlDocument();
            //xmlDoc.Load(ms);
            ////给文档添加<?xml version="1.0" encoding="utf-8"?>
            //XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null);
            //xmlDoc.InsertBefore(xmlDecl, xmlDoc.DocumentElement);


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
