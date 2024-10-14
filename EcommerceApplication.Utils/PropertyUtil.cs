using System.Data.SqlClient;

namespace DBUtils
{
    public static class PropertyUtil
    {
        public static SqlConnection getPropertyString()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
            return connection;
        }
    }
}