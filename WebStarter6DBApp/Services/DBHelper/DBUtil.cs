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
            //var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";
            //builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
           //     .AddJsonFile($"appsettings.{environment}.json", optional: true, reloadOnChange: true);
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
