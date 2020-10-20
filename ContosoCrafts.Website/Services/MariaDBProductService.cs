using System;
using System.Collections.Generic;
using System.Data;
using ContosoCrafts.Website.Models;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;

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

        public List<T> GetProducts<T,U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> products = connection.Query<T>(sql, parameters).ToList();
                return products;
            }
        }
        public List<T> SaveData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                List<T> products = connection.Query<T>(sql, parameters).ToList();
                return products;
            }
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}