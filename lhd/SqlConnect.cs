using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace lhd
{
    public class SqlConnect
    {
        //public static void sqlcon(string sqltype)
        //{
            
        //    switch (sqltype)
        //    {
        //        case "sqlserver":
        //            SqlConnection();
        //            break;
        //        case "mysql":
        //            MySqlConnection();
        //            break;
        //        default:
        //            //不处理
        //            break;
        //    }
        //}
        public static SqlConnection SqlConnection()
        {
            string sqlconnectionString = ConfigurationManager.ConnectionStrings["sqlconnectionString"].ToString();
            var connection = new SqlConnection(sqlconnectionString);
            connection.Open();
            return connection;
        }
        public static MySqlConnection MySqlConnection()
        {
            string mysqlconnectionString = ConfigurationManager.ConnectionStrings["mysqlconnectionString"].ToString();
            var connection = new MySqlConnection(mysqlconnectionString);
            connection.Open();
            return connection;
        }
    }
}
