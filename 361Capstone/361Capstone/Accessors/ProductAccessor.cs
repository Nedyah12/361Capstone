using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;
using System.ComponentModel;

namespace OnlineStore.Accessors {
    class ProductAccessor : IProductAccessor {
        private MySqlConnection conn;
        private DatabaseConnection dbConnection = new DatabaseConnection();

        public int InsertProduct(int categoryId, string name, 
                          string description, string manufInfo, 
                          string dimensions, double weight, 
                          double rating, int sku, int stockCount) {

            if(categoryId <= 0 || weight <= 0 || sku <= 0 || stockCount < 0) {
                return -1;
            } else if(rating <= 0 || rating > 5) {
                return -1;
            }


            int productId = 0;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Product (categoryId, name, description, manufacturerInfo, dimensions, weight, productRating, sku, stockCount) VALUES(@categoryId, @name, @desc, @manufInfo, @dim, @weight, @rating, @sku, @count);", conn);
                    cmd.Parameters.AddWithValue("@categoryId", categoryId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@desc", description);
                    cmd.Parameters.AddWithValue("@manufInfo", manufInfo);
                    cmd.Parameters.AddWithValue("@dim", dimensions);
                    cmd.Parameters.AddWithValue("@weight", weight);
                    cmd.Parameters.AddWithValue("@rating", rating);
                    cmd.Parameters.AddWithValue("@sku", sku);
                    cmd.Parameters.AddWithValue("@count", stockCount);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);

                    productId = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return productId;
        }

        public List<string> GetProductInfo(int productId) {
            if (productId < 1) {
                return null;
            }

            List<string> productInfo = new List<string>();

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Product WHERE productId=@productId", conn);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            for (int i = 1; i < 11; i++) {
                                productInfo.Add(reader[i].ToString());
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
            return productInfo;
        }

        public int GetIdFromName(string name) {
            if (name == null || name == "") {
                return -1;
            }

            int productId = 0;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT productId FROM Product WHERE name = @name;", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Prepare();

                    productId = Convert.ToInt32(cmd.ExecuteScalar());


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }

            return productId;
        }

        public int IncrementStockCount(int productId, int addNumber) {
            if(addNumber < 1) {
                return -1;
            }

            int updatedCount = 0;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Product SET stockCount=stockCount+@num WHERE productId=@productId", conn);
                    cmd.Parameters.AddWithValue("@num", addNumber);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT stockCount FROM Product WHERE productId = @productId;", conn);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    updatedCount = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return updatedCount;
        }

        public int DecrementStockCount(int productId, int removeNumber) {
            if (removeNumber < 1) {
                return -1;
            }

            int updatedCount = 0, currentCount = 0;

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT stockCount FROM Product WHERE productId = @productId;", conn);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Prepare();

                    currentCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if(currentCount < removeNumber) {
                        return -1;
                    }

                    cmd = new MySqlCommand("UPDATE Product SET stockCount=stockCount-@num WHERE productId=@productId", conn);
                    cmd.Parameters.AddWithValue("@num", removeNumber);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT stockCount FROM Product WHERE productId = @productId;", conn);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    updatedCount = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return updatedCount;
        }

        public void AttachSale(int productId, int saleId) {
            if (saleId < 1) {
                return;
            }

            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Product SET saleId = @saleId WHERE productId = @productId", conn);
                    cmd.Parameters.AddWithValue("@saleId", saleId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return;
        }

        public void DetachSale(int productId) {
            using (conn = dbConnection.getConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE Product SET saleId = null WHERE productId = @productId", conn);
                    cmd.Parameters.AddWithValue("@productId", productId);
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
