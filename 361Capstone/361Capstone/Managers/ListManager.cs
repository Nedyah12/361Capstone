using System;
using _361Capstone.Models;
using _361Capstone.Engine;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public class ListManager : IListManager
    {
        ListEngine Engine { get; set; } = new ListEngine();

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

        public Cart GetCart(int cartId)
        {
            return Engine.GetCart(cartId);
        }

        public List<string> GetProductInfo(int productId)
        {
            return Engine.GetProductInfo(productId);
        }

        public void InsertCartProduct(int cartId, int productId, int quantity)
        {
            return;
        }

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
