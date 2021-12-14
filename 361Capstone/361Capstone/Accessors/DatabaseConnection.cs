using System;
using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    public class DatabaseConnection : IDatabaseConnection {
        // Returns a MySqlConnection that allows a connection
        // to the database hosted on cse.unl.edu.
        public MySqlConnection GetConnection() {
            string server = "cse.unl.edu";
            string database = "cdyoung";
            string port = "3306";
            string username = "cdyoung";
            string password = "ANk-4G";
            string connectionString = String.Format("Server={0};Database={1};port={2};Uid={3};Pwd={4}",
                                                    server, database, port, username, password);

            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
