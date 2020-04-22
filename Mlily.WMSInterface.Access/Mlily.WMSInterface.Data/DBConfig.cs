using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml;

namespace Mlily.WMSInterface.Data
{
    public class DBConfig
    {
       private static List<DBEntity> lst = null;

        /// <summary>
        /// 获取数据库配置文件信息，若数据库文件发生变更，需重新启动程序
        /// </summary>
        /// <returns></returns>
        public static List<DBEntity> GetDBS()
        {
            if (lst == null || lst.Count == 0)
            {
                lst = new List<DBEntity>();
                DBEntity info = null;
                string configPath = AppDomain.CurrentDomain.BaseDirectory + "/Database.config";
                XmlDocument xml = new XmlDocument();
                xml.Load(configPath);
                XmlNodeList NodeList = xml.SelectNodes("/DBS/DB");
                for (int i = 0; i < NodeList.Count; i++)
                {
                    info = new DBEntity();
                    info.name = NodeList[i].Attributes["name"].Value;
                    info.value = NodeList[i].Attributes["value"].Value;
                    info.dbtype = NodeList[i].Attributes["dbtype"].Value;
                    info.isdefault = NodeList[i].Attributes["isdefault"].Value;
                    info.dbName = NodeList[i].Attributes["dbName"].Value;
                    lst.Add(info);
                }
            }

            return lst;
        }
    }
    public class DBEntity
    {
        public string name { get; set; }
        public string value { get; set; }
        public string dbtype { get; set; }
        public string isdefault { get; set; }
        public string dbName { get; set; }
    }
}
