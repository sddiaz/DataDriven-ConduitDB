using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

using SQL_Connection = Microsoft.Data.SqlClient.SqlConnection; 

namespace CableAPI.Controllers
{
    public static class SqlDataAccess
    {
        // Obtain Database Connection String via our Environment Variable
        public static string GetConnectionString()
        {
            string? connectionString = Environment.GetEnvironmentVariable("CableDBConnection", EnvironmentVariableTarget.User);

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ApplicationException("Connection String not found.");
            }

            return connectionString;
        }
        // LoadData is used for GET Requests
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection connection = new SQL_Connection(GetConnectionString()))
            {

                return connection.Query<T>(sql).ToList();

            }
        }
        // SaveData is used for POST Requests
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection connection = new SQL_Connection(GetConnectionString()))
            {
                return connection.Execute(sql, data);
            }
        }
    }
}