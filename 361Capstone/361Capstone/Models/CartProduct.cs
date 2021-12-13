namespace _361Capstone.Models
{
    public class CartProduct : ICartProduct
    {
        private int CartProductId { get; set; }
        private Product Product { get; set; }
        private int Quantity { get; set; }

        private int CartId { get; set; }

        public CartProduct(int cpId, int cId, Product prod, int quant)
        {
            CartProductId = cpId;
            CartId = cId;
            Product = prod;
            Quantity = quant;
        }

        public int GetCartProductId()
        {
            return CartProductId;
        }
        public int GetCartId()
        {
            return CartId;
        }
        public Product GetProduct()
        {
            return Product;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        
    }
}
