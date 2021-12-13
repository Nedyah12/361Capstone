﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    class PaymentInfoAccessor : IPaymentInfoAccessor {
        private MySqlConnection conn;
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public void InsertPaymentInfo(int userId, int creditCardNumber, int expMonth, int expYear, int cvvCode) {
            if (userId < 1 || creditCardNumber <= 0 || cvvCode <= 0) {
                return;
            } else if (expMonth < 1 || expMonth > 12) {
                return;
            } else if (expYear < 1 || expYear > 2999) {
                return;
            }

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO PaymentInfo (userId, creditCardNumber, expirationMonth, expirationYear, cvvCode) VALUES(@userId, @ccn, @expm, @expy, @cvv);", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@ccn", creditCardNumber);
                    cmd.Parameters.AddWithValue("@expm", expMonth);
                    cmd.Parameters.AddWithValue("@expy", expYear);
                    cmd.Parameters.AddWithValue("@cvv", cvvCode);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                }
            }
        }

        public List<string> GetPaymentInfo(int userId) {
            if (userId < 1) {
                return null;
            }

            List<string> paymentInfo = new List<string>();

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM PaymentInfo WHERE userId=@userId", conn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Prepare();

                    try {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read()) {
                            for (int i = 0; i < 6; i++) {
                                paymentInfo.Add(reader[i].ToString());
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
            return paymentInfo;
        }
    }
}
