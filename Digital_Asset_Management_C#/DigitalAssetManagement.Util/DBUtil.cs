using System;
using Microsoft.Data.SqlClient;
// using System.Configuration;
// using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
// using Microsoft.Data.SqlClient;
// using Microsoft.IdentityModel.Protocols;
namespace DigitalAssetManagement.Util;

public static class DBUtil
{
    // readonly static SqlConnection sqlConnection;
    private static string _connectionString;
        // static DBUtil()
        // {
        //     sqlConnection = new SqlConnection();
        //     sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        // }
        // Static constructor to initialize the connection string
        static DBUtil()
        {
            // Create a configuration builder to read the appsettings.json file
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory) // Set the base path to the application's base directory
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) // Add the appsettings.json file to the configuration
                .Build(); // Build the configuration

            // Retrieve the connection string named "DefaultConnection" from the configuration
            _connectionString = configuration.GetConnectionString("MyDBconnection");
        }

        // Method to get an open SQL connection
        public static SqlConnection GetConnection()
        {
            // Create a new SqlConnection using the connection string
            SqlConnection connection = new SqlConnection(_connectionString);
            // Open the connection
            // connection.Open();
            // Return the open connection
            return connection;
        }

        // public static SqlConnection SqlConnection => sqlConnection;

        // public static void CloseConnection()
        // {
        //     if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
        //     {
        //         sqlConnection.Close();
                
        //     }
        // }
}
