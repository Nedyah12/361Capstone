using _361Capstone.Accessors;
using _361Capstone.Models;
using System;
using System.Collections.Generic;

namespace _361Capstone.Engine
{
    public class CheckoutEngine : ICheckoutEngine
    {
        AddressAccessor addressAccessor = new AddressAccessor();
        PaymentInfoAccessor paymentInfoAccessor = new PaymentInfoAccessor();
        ProductAccessor productAccessor = new ProductAccessor();
        CartProductAccessor cartProductAccessor = new CartProductAccessor();

        // Returns a list of strings that contain the address info
        // of a user.
        public List<String> GetAddressInfo(int userId) {
            List<String> addressInfo = addressAccessor.GetAddressInfo(userId);
            return addressInfo;
        }

        // Returns a list of strings that contain the payment info
        // of a user.
        public List<String> GetPaymentInfo(int userId) {
            List<String> paymentInfo = paymentInfoAccessor.GetPaymentInfo(userId);
            return paymentInfo;
        }

        // Completes the transaction, or more specifically, decrements the
        // stock count of necessary products and removes each product from a
        // user's cart.
        public void CompleteTransaction(int userId, List<Product> products) {
            foreach(Product product in products) {
                productAccessor.DecrementStockCount(product.GetProductId(), product.GetStockCount());
                cartProductAccessor.RemoveCartProduct(userId, product.GetProductId());           
            }
        }


    }
}
