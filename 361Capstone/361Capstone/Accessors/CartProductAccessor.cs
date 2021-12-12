﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace _361Capstone.Accessors {
    class CartProductAccessor : ICartProductAccessor {
        private MySqlConnection conn;
        private readonly DatabaseConnection dbConnection = new DatabaseConnection();

        public bool InsertCartProduct(int cartId, int productId, int quantity) {
            if(cartId < 1 || productId < 1 || quantity < 1) {
                return false;
            }

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO CartProduct (cartId, productId, quantity) VALUES(@cartId, @productId, @quantity);", conn);
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public bool RemoveCartProduct(int cartId, int productId) {
            if (cartId < 1 || productId < 1) {
                return false;
            }

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("DELETE FROM CartProduct WHERE cartId=@cartId AND productId=@productId;", conn);
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    conn.Close();
                } catch (MySql.Data.MySqlClient.MySqlException ex) {
                    Console.WriteLine("SQL ERROR: " + ex.Message);
                    return false;
                }
            }
            return true;
        }

        public void ChangeCartProductQuantity(int cartId, int productId, int newQuantity) {
            if (cartId < 1 || productId < 1 || newQuantity < 1) {
                return;
            }

            using (conn = dbConnection.GetConnection()) {
                try {
                    conn.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE CartProduct SET quantity=@newQuantity WHERE cartId=@cartId AND productId=@productId;", conn);
                    cmd.Parameters.AddWithValue("@cartId", cartId);
                    cmd.Parameters.AddWithValue("@productId", productId);
                    cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
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
