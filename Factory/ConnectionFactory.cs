using System.Data;
using System.Data.SqlClient;

namespace Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "";
            connection.Open();

            return connection;
        }
    }
}
