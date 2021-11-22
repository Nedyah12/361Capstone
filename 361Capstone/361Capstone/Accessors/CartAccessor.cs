using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineStore.Accessors {
    class CartAccessor : ICartAccessor {
        private MySqlConnection conn;
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public void InsertCart(int userId) {
            if (userId < 1) {
                return;
            }

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Cart (userId) VALUES(@userId);", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }
    }
}
