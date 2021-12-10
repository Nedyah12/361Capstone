using System;
using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    public class DatabaseConnection : IDatabaseConnection {
        public MySqlConnection GetConnection() {
            string server = "127.0.0.1";
            string database = "onlinestoredb";
            string port = "3306";
            string username = "root";
            string password = "";
            string connectionString = String.Format("Server={0};Database={1};port={2};Uid={3};Pwd={4}",
                                                    server, database, port, username, password);

            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
