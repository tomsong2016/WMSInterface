using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Mlily.WMSInterface.Console
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

    [XmlRoot("SerInterface"), Serializable]
    public class SerInterface<TInterface> : IXmlSerializable
    {
        public TInterface Source => (TInterface)mSource;
        string mTypeName;
        object mSource;


        public SerInterface()
        {

        }

        public SerInterface(object interfaceObj)
        {
            this.mSource = interfaceObj;
            mTypeName = mSource.GetType().FullName;
        }

        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            var typeSer = new XmlSerializer(typeof(string));
            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                reader.ReadStartElement("Type");
                mTypeName = typeSer.Deserialize(reader) as string;

                reader.ReadEndElement();

                var sourceSer = new XmlSerializer(Type.GetType(mTypeName));
                reader.ReadStartElement("Object");
                mSource = sourceSer.Deserialize(reader);
                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            var typeSer = new XmlSerializer(typeof(string));
            var sourceSer = new XmlSerializer(mSource.GetType());

            writer.WriteStartElement("Type");
            typeSer.Serialize(writer, mTypeName);
            writer.WriteEndElement();
            writer.WriteStartElement("Object");
            sourceSer.Serialize(writer, mSource);
            writer.WriteEndElement();
        }
    }


    public class Test
    {
        public void Test1()
        {
            //把接口嵌套
            //IXXX tmp = new Class1();
            //var serInterface = new SerInterface<IXXX>(tmp);


            ////序列化
            //var xmlSer = new XmlSerializer(serInterface.GetType());
            //var writer = new MemoryStream();

            //xmlSer.Serialize(writer, serInterface);

            //StreamReader sr = new StreamReader(writer);
            //var serStr = Encoding.UTF8.GetString(writer.ToArray());

            //writer.Flush();
            //writer.Close();
            //sr.Close();


            ////反序列化
            //xmlSer = new XmlSerializer(typeof(SerInterface<IXXX>));
            //TextReader reader = new StringReader(serStr);
            //var deSer = xmlSer.Deserialize(reader);

            ////原始数据
            //var sourceInterfaceData = (deSer as SerInterface<IXXX>).Source;
        }
    }
}