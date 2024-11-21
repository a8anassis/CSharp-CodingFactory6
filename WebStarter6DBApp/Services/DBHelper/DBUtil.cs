using Microsoft.Data.SqlClient;

namespace WebStarter6DBApp.Services.DBHelper
{
    public static class DBUtil
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            string? url = configuration.GetConnectionString("DefaultConnection");

            try
            {
                connection = new SqlConnection(url);
                return connection;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
