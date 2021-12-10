using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace _361Capstone.Accessors {
    public class UserAccessor : IUserAccessor {
        private MySqlConnection conn;
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public int InsertUser(string username, string password) {
            if (username == null || username == "" || password == null || password == "") {
                return -1;
            } else if(GetUserIdFromUsername(username) != 0) {
                return -1;
            }


            int userId = -1;

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO User (username, password) VALUES(@username, SHA2(@password, 256));", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);

                    userId = Convert.ToInt32(cmd.ExecuteScalar());

                    CartAccessor cartAccessor = new CartAccessor();
                    cartAccessor.InsertCart(userId);

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return userId;

        }

        public void ChangePassword(int userId, string newPassword) {
            if (userId < 1 || newPassword == null || newPassword == "") {
                return;
            }

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE User SET password = @password WHERE userId = @userId", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@password", newPassword);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return;
        }

        public bool ValidateUserInfo(string username, string password) {
            if (username == null || username == "" || password == null || password == "") {
                return false;
            }

            int userId = -1;

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT userId FROM User WHERE username=@username AND password=SHA2(@password, 256)", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Prepare();

                    userId = Convert.ToInt32(cmd.ExecuteScalar());

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            if(userId != 0) {
                return true;
            }
            return false;
        }

        // Checks whether the new email is available or not.
        // Returns true if email is not in use. Otherwise, returns false.
        public int GetUserIdFromUsername(string username) {
            if (username == null || username == "") {
                return -1;
            }

            int userId = -1;

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT userId FROM User WHERE username = @username;", conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Prepare();

                    userId = Convert.ToInt32(cmd.ExecuteScalar());


                    conn.Close();
                } catch(MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
                
            }

            return userId;
        }


        public string GetUsername(int userId) {
            if (userId < 1) {
                return null;
            }

            string userUsername = "";

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT username FROM User WHERE userId = @userId;", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            userUsername = reader[0].ToString();
                        }
                    } catch (InvalidOperationException ex) {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return userUsername;
        }

        public string GetPassword(int userId) {
            if (userId < 1) {
                return null;
            }

            string userPassword = "";

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT password FROM User WHERE userId = @userId;", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            userPassword = reader[0].ToString();
                        }
                    } catch (InvalidOperationException ex) {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return userPassword;
        }

        public List<int> GetAllCartItems(int userId) {
            if(userId < 1) {
                return null;
            }

            List<int> productIdsAndQuantities = new List<int>();

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT productId, quantity FROM CartProduct WHERE cartId=@cartId;", conn);
                    cmd.Parameters.AddWithValue("@cartId", userId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while(reader.Read()) {
                            productIdsAndQuantities.Add((int)reader[0]);
                            productIdsAndQuantities.Add((int)reader[1]);
                        }
                    } catch (InvalidOperationException ex) {
                        Console.WriteLine("ERROR: " + ex.Message);
                    }


                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }

            }
            return productIdsAndQuantities;
        }
    }
}
