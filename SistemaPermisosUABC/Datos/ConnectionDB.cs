using System.Data.SqlClient;
using System.Configuration;

namespace Datos
{
    public class ConnectionDB
    {
        public string connectionString;
        public SqlConnection connection = null;
        public ConnectionDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["PermisosDBConnectionString"].ConnectionString;
            connection = new SqlConnection(connectionString);

        }
    }
}



