using System.Collections.Generic;

namespace _361Capstone.Engine {
    interface IListEngine {
        void InsertCartProduct(int cartId, int productId, int quantity);
        void RemoveCartProduct(int cartId, int productId);
        void ChangeCartProductQuantity(int cartId, int productId, int newQuantity);
        List<string> GetProductInfo(int productId);

    }
}