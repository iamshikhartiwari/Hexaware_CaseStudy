using System.Data.SqlClient;

namespace DBUtils
{
    public static class PropertyUtil
    {
        public static SqlConnection getPropertyString()
        {
            SqlConnection connection = new SqlConnection();
            string connectionstring = "Server=localhost,1433;Database=Ecommerce;User Id=sa;Password=YourStrong@Passw0rd;TrustServerCertificate=True;";
            connection.ConnectionString = connectionstring;
            return connection;
        }

        

    }
}