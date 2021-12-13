using System;
using System.Collections.Generic;

using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    class CategoryAccessor : ICategoryAccessor {
        private MySqlConnection conn;
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public int InsertCategory(string title) {
            if(title == null || title == "") {
                return -1;
            }

            int categoryId = -1;

            using (conn = dbConnection.GetConnection()) {
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

            using (conn = dbConnection.GetConnection()) {
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

            using (conn = dbConnection.GetConnection()) {
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
            using (conn = dbConnection.GetConnection()) {
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

        public List<List<String>> GetAllCategories() {
            List<List<String>> allCategories = new List<List<String>>();

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Category", conn);
                    cmd.Prepare();

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        List<String> tempList = new List<String>();
                        for(int i=0;i<3;i++) {
                            tempList.Add(reader[i].ToString());
                        }
                        allCategories.Add(tempList);
                    }

                        conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }

            return allCategories;
        }
    }
}
