using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineStore.Accessors {
    class CategoryAccessor : ICategoryAccessor {
        private MySqlConnection conn;
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int InsertCategory(string title) {
            if(title == null || title == "") {
                return -1;
            }

            int categoryId = -1;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Category (title) VALUES(@title);", conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);

                    categoryId = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            return categoryId;
        }
        public int GetIdFromTitle(string title) {
            if (title == null || title == "") {
                return -1;
            }

            int categoryId = -1;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT categoryId FROM Category WHERE title = @title;", conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Prepare();

                    categoryId = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }

            return categoryId;
        }

        public void AttachSale(int categoryId, int saleId) {
            if (saleId < 1) {
                return;
            }

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Category SET saleId = @saleId WHERE categoryId = @categoryId", conn);
                    cmd.Parameters.AddWithValue("@saleId", saleId);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return;
        }

        public void DetachSale(int categoryId) {
            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Category SET saleId = null WHERE categoryId = @categoryId", conn);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return;
        }
    }
}
