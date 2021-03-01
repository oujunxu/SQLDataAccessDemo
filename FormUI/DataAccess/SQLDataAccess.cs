using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FormUI 
{
    /**
     * Class which connects to the database through the connectionstring from appconfig.
     */
    public class SQLDataAccess
    {
        public static string GetConnectionString(string connectionName = "DemoData")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        //using connectionstring to get data from the database.
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                return connection.Query<T>(sql).ToList();
            }   
        }

        //using connectionString to save data to the database.
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection connection = new SqlConnection(GetConnectionString()))
            {
                return connection.Execute(sql, data);
            }
        }
    }
}
