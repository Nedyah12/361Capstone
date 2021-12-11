using System;
namespace _361Capstone.Models
{
    public interface ICartProduct
    {
        int GetCartProductId();
        Product GetProduct();
        int GetCartId();
        int GetQuantity();
    }
}
