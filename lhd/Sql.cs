using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace lhd
{
    public class Sql
    {
        public void zeng(MySqlConnection mysqlconnection)
        {
            //单行增
            using (mysqlconnection)
            {
                Users user = new Users();
                user.Name = "CNKI";
                user.Age = 38;
                string sqlCommandText = @"INSERT INTO USERS(Name,Age)VALUES(@Name,@Age)";
                int result = mysqlconnection.Execute(sqlCommandText, user);
            }
        }
    }
}
