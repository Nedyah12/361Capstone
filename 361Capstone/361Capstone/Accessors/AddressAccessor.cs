using System;
using System.Collections.Generic;


using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    public class AddressAccessor : IAddressAccessor {
        private MySqlConnection conn;
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        // Inserts an address for a user based on the userId.
        public void InsertAddress(int userId, string street, string city, string state, int zipCode, string country) {
            if (userId < 1) {
                return;
            } else if (street == null || street == "") {
                return;
            } else if(city == null || city == "") {
                return;
            } else if (country == null || country == "") {
                return;
            }


            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO Address (userId, street, city, state, zipCode, country) VALUES(@userId, @street, @city, @state, @zipCode, @country);", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@state", state);
                    cmd.Parameters.AddWithValue("@zipCode", zipCode);
                    cmd.Parameters.AddWithValue("@country", country);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }

        // Returns a list of strings that holds the address information/
        // for a given user.
        public List<string> GetAddressInfo(int userId) {
            if (userId < 1) {
                return null;
            }

            List<string> addressInfo = new List<string>();

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM Address WHERE userId=@userId", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if(reader.Read()) {
                            for (int i = 0; i < 7; i++) {
                                addressInfo.Add(reader[i].ToString());
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
            return addressInfo;
        }
    }
}
