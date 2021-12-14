using System;
using _361Capstone.Models;
using _361Capstone.Engine;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public class ListManager : IListManager
    {
        ListEngine Engine { get; set; } = new ListEngine();

        // Changes the quantity of a product in a user's cart.
        public void ChangeCartProductQuantity(int cartId, int productId, int newQuantity)
        {
            try
            {
                Engine.ChangeCartProductQuantity(cartId, productId, newQuantity);

            }
            catch (NullReferenceException)
            {
                return;
            }

            return;
        }

        // Returns a list of strings of product information
        // for a given product.
        public List<string> GetProductInfo(int productId)
        {
            return Engine.GetProductInfo(productId);
        }

        public void InsertCartProduct(int cartId, int productId, int quantity)
        {
            return;
        }

        // Removes a specified product from a user's cart.
        public void RemoveCartProduct(int cartId, int productId)
        {
            try
            {
                Engine.RemoveCartProduct(cartId, productId);

            }
            catch (NullReferenceException)
            {
                return;
            }

            return;
        }
    }

}
