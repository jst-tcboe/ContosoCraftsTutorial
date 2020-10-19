using System;
using MySql.Data.MySqlClient;
namespace ContosoCrafts.Website.Services
{
    public class MariaDBProductService : IDisposable
    {
        public MySqlConnection Connection;

        public MariaDBProductService(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            this.Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}