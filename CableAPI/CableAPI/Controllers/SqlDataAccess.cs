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
        public static List<T> LoadData<T>(string sql, string ID)
        {
            using (IDbConnection connection = new SQL_Connection(GetConnectionString()))
            {
                if (ID != null)
                {
                    // Correct the SQL query to use parameterized query
                    sql = @"SELECT * FROM dbo.Cable WHERE ID = @ID;";
                    var parameters = new { ID };
                    return connection.Query<T>(sql, parameters).ToList();
                }
                else
                {
                    // If ID is null, return all records
                    return connection.Query<T>(sql, null).ToList();
                }
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