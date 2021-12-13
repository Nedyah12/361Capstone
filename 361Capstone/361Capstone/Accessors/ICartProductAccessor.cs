namespace _361Capstone.Accessors {
    interface ICartProductAccessor {
        bool InsertCartProduct(int cartId, int productId, int quantity);
        bool RemoveCartProduct(int cartId, int productId);
        void ChangeCartProductQuantity(int cartId, int productId, int newQuantity);

    }
}
