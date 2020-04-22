using SqlSugar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mlily.WMSInterface.Data
{
    public class DBContext<T> where T:class,new()
    {
        public SqlSugarClient Db = null;
        List<DBEntity> lst = DBConfig.GetDBS();
        public DBContext()
        {
            GetDB();
            //Db.Aop.OnLogExecuting = (sql, pars) =>
            //{
            //    Console.WriteLine(sql + "\r\n" +
            //                      Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            //    //logger.Info(sql);
            //    Console.WriteLine();
            //};
        }

        private DBContext(string _conStr)
        {
            GetDB(_conStr);
            //Db.Aop.OnLogExecuting = (sql, pars) =>
            //{
            //    Console.WriteLine(sql + "\r\n" +
            //                      Db.Utilities.SerializeObject(pars.ToDictionary(it => it.ParameterName, it => it.Value)));
            //    //logger.Info(sql);
            //    Console.WriteLine();
            //};
        }

        public DBContext<T> DBInstance(string _conStr)
        {
            return new DBContext<T>(_conStr);
        }

        #region 查询实体类
        /// <summary>
        /// 查询所有数据
        /// </summary>
        /// <returns></returns>
        public IList<T> GetList()
        {
            return Db.Queryable<T>().ToList();
        }

        /// <summary>
        /// 根据sql查询数据
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        public IList<T> GetList(string strSql,object parm)
        {
            return Db.Ado.SqlQuery<T>(strSql, parm);
        }

        /// <summary>
        /// 根据条件查询数据
        /// </summary>
        /// <param name="whereExpress">查询条件</param>
        /// <returns></returns>
        public IList<T> GetList(Expression<Func<T, bool>> whereExpress)
        {
            return Db.Queryable<T>().Where(whereExpress).ToList();
        }
        /// <summary>
        /// 查询前几条数据
        /// </summary>
        /// <param name="top">数据条数</param>
        /// <returns></returns>
        public IList<T> GetList(int top)
        {
            return Db.Queryable<T>().Take(top).ToList();
        }
        /// <summary>
        /// 根据查询条件筛选前几条数据
        /// </summary>
        /// <param name="top">数据条数</param>
        /// <param name="whereExpress">返回的条数</param>
        /// <returns></returns>
        public IList<T> GetList(int top, Expression<Func<T, bool>> whereExpress)
        {
            return Db.Queryable<T>().Where(whereExpress).Take(top).ToList();
        }
        /// <summary>
        /// 分页查询数据
        /// </summary>
        /// <param name="whereExpress"></param>
        /// <param name="orderFields"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public IList<T> GetPageList(Expression<Func<T, bool>> whereExpress,string orderFields, int pageIndex, int pageSize, ref int total)
        {
            return Db.Queryable<T>().Where(whereExpress).OrderBy(orderFields).ToPageList(pageIndex,pageSize,ref total).ToList();
        }
        /// <summary>
        /// 查询实体类
        /// </summary>
        /// <param name="keyid">主键</param>
        /// <returns></returns>
        public T GetEntity(object keyid)
        {
            return Db.Queryable<T>().InSingle(keyid);
        }


        #endregion

        #region 操作实体类
        /// <summary>
        /// 批量插入数据
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int Insert(List<T> lst)
        {
            return Db.Insertable<T>(lst).ExecuteCommand();
        }

        /// <summary>
        /// 插入单条数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Insert(T info)
        {
            return Db.Insertable<T>(info).ExecuteCommand();
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Update(T info)
        {
            return Db.Updateable<T>(info).ExecuteCommand();
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int Update(List<T> lst)
        {
            return Db.Updateable<T>(lst).ExecuteCommand();
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int Delete(T info)
        {
            return Db.Deleteable<T>(info).ExecuteCommand();
        }
        /// <summary>
        /// 删除多条数据
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public int Delete(List<T> lst)
        {
            return Db.Deleteable<T>(lst).ExecuteCommand();
        }
        /// <summary>
        /// 根据主键删除数据
        /// </summary>
        /// <param name="keyvalue"></param>
        /// <returns></returns>
        public int Delete(object keyvalue)
        {
            return Db.Deleteable<T>().In(keyvalue).ExecuteCommand();
        }
        /// <summary>
        /// 根据条件删除数据
        /// </summary>
        /// <param name="whereExpress"></param>
        /// <returns></returns>
        public int Delete(Expression<Func<T, bool>> whereExpress)
        {
            return Db.Deleteable<T>().Where(whereExpress).ExecuteCommand();
        }

       

        #endregion

        #region 数据库操作
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="param">参数，格式：new {id="",name="",......}</param>
        /// <returns></returns>
        public int ExcuteSql(string strSql,object param)
        {
            return Db.Ado.ExecuteCommand(strSql, param);
        }
        /// <summary>
        /// 查询SQL返回datatable
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="param">参数，格式：new {id="",name="",......}</param>
        /// <returns></returns>
        public DataTable GetDataTable(string strSql, object param)
        {
            return Db.Ado.GetDataTable(strSql, param);
        }


        /// <summary>
        /// 获取第一行第一列
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="param">参数，格式：new {id="",name="",......}</param>
        /// <returns></returns>
        public object GetScalar(string strSql, object param)
        {
            return Db.Ado.GetScalar(strSql, param);
        }
        /// <summary>
        ///执行存储过程，返回结果以datatable的格式体现
        /// </summary>
        /// <param name="strSql">sql语句</param>
        /// <param name="param">参数，格式：new {id="",name="",......}</param>
        /// <returns></returns>
        public DataTable ExcuteProc(string strSql, object param)
        {
            return Db.Ado.UseStoredProcedure().GetDataTable(strSql, param);
        }
        /// <summary>
        /// 批量执行sql，调用事务
        /// </summary>
        /// <param name="dirSql">sql语句集合</param>
        /// <returns></returns>
        public int ExcuteTrans(Dictionary<string,object> dirSql)
        {
            try
            {
                Db.Ado.BeginTran();
                foreach (var  keys in dirSql.Keys)
                {
                    Db.Ado.ExecuteCommand(keys, dirSql[keys]);
                }
                Db.Ado.CommitTran();
                return 1;
            }
            catch (Exception ex)
            {
                Db.Ado.RollbackTran();
                return 0;
            }
        }

        #endregion

        #region 私有方法
        /// <summary>
        /// 获取SqlSugarClient
        /// </summary>
        /// <param name="_conString">连接字符串</param>
        /// <param name="_dbType">数据库类型</param>
        /// <returns></returns>
        private SqlSugarClient GetClient(string _conString, SqlSugar.DbType _dbType)
        {
            return new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = _conString,
                DbType = _dbType,
                InitKeyType = InitKeyType.Attribute,//从特性读取主键和自增列信息
                IsAutoCloseConnection = true,//开启自动释放模式
            });
        }

        /// <summary>
        /// 获取数据库
        /// </summary>
        /// <param name="_constr"></param>
        private void GetDB(string _constr="")
        {
            DBEntity info = null;
            if (lst != null)
            {
                if (string.IsNullOrEmpty(_constr))
                    info = lst.Where(x => x.isdefault == "1").FirstOrDefault();
                else
                    info = lst.Where(x => x.name == _constr).FirstOrDefault();
            }
            if (info!=null)
            {
                switch (info.dbtype)
                {
                    case "sqlserver":
                        Db = GetClient(info.value, SqlSugar.DbType.SqlServer);
                        break;
                    case "mysql":
                        Db = GetClient(info.value, SqlSugar.DbType.MySql);
                        break;
                    case "oracle":
                        Db = GetClient(info.value, SqlSugar.DbType.Oracle);
                        break;
                }
            }
            else
                throw new Exception("数据库获取失败");
        }
        #endregion
    }
}
