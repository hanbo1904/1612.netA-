using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MySql.Data.MySqlClient;

namespace Services
{
    public class DapperDbHelper<T>
    {
        //链接配置字符串
        private static readonly string ConnStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

        /// <summary>
        /// 查询list 集合/
        /// </summary>
        /// <param name="sqlOrProc">sql语句</param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<T> GetList(string sqlOrProc, object obj = null)
        {
            //异常处理语句
            try
            {
                //链接字符串
                using (var conn = new MySqlConnection(ConnStr))
                {
                    //执行查询list集合功能
                    var list = conn.Query<T>(sqlOrProc, obj).ToList();
                    return list;
                }
            }
            catch (Exception )
            {
                //如果异常则返回null
                return null;
            }
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sqlOrProc"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ExecuteSql(string sqlOrProc, object obj = null)
        {
            //异常处理语句
            try
            {
                //使用链接字符串
                using (var conn = new MySqlConnection(ConnStr))
                {
                    //打开数据库
                    conn.Open();
                    //执行增删改操作
                    return conn.Execute(sqlOrProc, obj);
                }
            }
            catch (Exception )
            {
                //如果执行失败则返回0
                return 0;
            }
        }

        /// <summary>
        /// 查询Model对象
        /// </summary>
        /// <param name="sqlOrProc">sql语句</param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T GetModel(string sqlOrProc, object obj = null)
        {
            //异常处理
            try
            {
                //使用using 执行自动释放
                using (var conn = new MySqlConnection(ConnStr))
                {
                    //执行query执行查询一个对象
                    return conn.Query<T>(sqlOrProc, obj).FirstOrDefault();

                }
            }
            catch (Exception)
            {
                //如果异常则返回默认的T
                return default(T);
            }
        }

        /// <summary>
        /// 查询首航首列
        /// </summary>
        /// <param name="sqlOrProc">sql语句</param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ExecuteScalar(string sqlOrProc, object obj = null)
        {
            //异常处理
            try
            {
                //使用using 执行自动释放
                using (var conn = new MySqlConnection(ConnStr))
                {
                    //执行query执行查询一个对象
                    int i = Convert.ToInt32(conn.ExecuteScalar(sqlOrProc, obj));
                    return i;
                }
            }
            catch (Exception )
            {
                //如果异常则返回0
                return 0;
            }
        }
    }
}
