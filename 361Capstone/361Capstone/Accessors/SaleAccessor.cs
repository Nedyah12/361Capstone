using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace OnlineStore.Accessors {
    class SaleAccessor : ISaleAccessor {
        private MySqlConnection conn;
        private DatabaseConnection dbConnection = new DatabaseConnection();
        public int InsertSale(string title, int percentage, DateTime startDate, DateTime endDate) {
            if(percentage <= 0 || startDate == null || endDate == null) {
                return -1;
            }

            int saleId = -1;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Sale (title, percentage, startDate, endDate) VALUES(@title, @pct, @start, @end);", conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@pct", percentage);
                    cmd.Parameters.AddWithValue("@start", startDate);
                    cmd.Parameters.AddWithValue("@end", endDate);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);

                    saleId = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
            return saleId;
        }
        public List<string> GetSaleInfo(int saleId) {
            if (saleId < 1) {
                return null;
            }

            List<string> saleInfo = new List<string>();

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Sale WHERE saleId=@saleId", conn);
                    cmd.Parameters.AddWithValue("@saleId", saleId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            for (int i = 1; i < 5; i++) {
                                saleInfo.Add(reader[i].ToString());
                            }
                        }

                    } catch (InvalidOperationException ex) {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return saleInfo;
        }
        public int GetIdFromTitle(string title) {
            if (title == null || title == "") {
                return -1;
            }

            int saleId = -1;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT saleId FROM Sale WHERE title = @title;", conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Prepare();

                    saleId = Convert.ToInt32(cmd.ExecuteScalar());


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }

            return saleId;
        }
    }
}
