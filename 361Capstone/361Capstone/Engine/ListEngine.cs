using System;
using _361Capstone.Accessors;
using System.Collections.Generic;

namespace _361Capstone.Engine {
    public class ListEngine : IListEngine {
        CartProductAccessor Accessor { get; set; } = new CartProductAccessor();
        ProductAccessor ProductAccessor { get; set; } = new ProductAccessor();

        public ListEngine() {
            Accessor = new CartProductAccessor();
            ProductAccessor = new ProductAccessor();
        }

        // Changes the quantity of a product in a user's cart.
        public void ChangeCartProductQuantity(int cartId, int productId, int newQuantity) {
            try {
                Accessor.ChangeCartProductQuantity(cartId, productId, newQuantity);
            } catch (ArgumentNullException) {
                return;
            }

            return;
        }

        // Returns a list of strings that contain the information about
        // a product.
        public List<string> GetProductInfo(int productId) {
            return ProductAccessor.GetProductInfo(productId);
        }


        public void InsertCartProduct(int cartId, int productId, int quantity) {
            return;
        }

        // Removes a product from a user's cart.
        public void RemoveCartProduct(int cartId, int productId) {
            try {
                Accessor.RemoveCartProduct(cartId, productId);
            } catch (ArgumentNullException) {
                return;
            }

            return;
        }
    }
}