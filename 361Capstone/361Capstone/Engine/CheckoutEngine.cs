using _361Capstone.Accessors;
using _361Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class CheckoutEngine : ICheckoutEngine
    {
        AddressAccessor addressAccessor = new AddressAccessor();
        PaymentInfoAccessor paymentInfoAccessor = new PaymentInfoAccessor();
        ProductAccessor productAccessor = new ProductAccessor();
        CartProductAccessor cartProductAccessor = new CartProductAccessor();

        public List<String> GetAddressInfo(int userId) {
            List<String> addressInfo = addressAccessor.GetAddressInfo(userId);
            return addressInfo;
        }

        public List<String> GetPaymentInfo(int userId) {
            List<String> paymentInfo = paymentInfoAccessor.GetPaymentInfo(userId);
            return paymentInfo;
        }

        public void CompleteTransaction(int userId, List<Product> products) {
            foreach(Product product in products) {
                productAccessor.DecrementStockCount(product.GetProductId(), product.GetStockCount());
                cartProductAccessor.RemoveCartProduct(userId, product.GetProductId());           
            }
        }


    }
}
