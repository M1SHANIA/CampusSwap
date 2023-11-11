using Microsoft.Data.Sqlite;
using System;
using System.Data;

namespace WpfApp1.Model
{
    internal class DatabaseContext
    {
        private readonly string _connectionString;

        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
            => new SqliteConnection(_connectionString);

        public bool TestConnection()
        {
            try
            {
                using var connection = new SqliteConnection(_connectionString);
                connection.Open(); // Попытка открыть соединение с базой данных
                return true; // Успех, если нет исключения
            }
            catch (Exception ex)
            {
                // Здесь вы можете обработать исключение, например, логировать ошибку
                return false;
            }
        }
    }
}
