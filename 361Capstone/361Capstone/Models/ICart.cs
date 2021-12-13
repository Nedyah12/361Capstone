using System.Collections.Generic;

namespace _361Capstone.Models
{
    public interface ICart
    {   
        int GetCartId();
        int GetUserId();

        List<CartProduct> GetCartProducts();
    }
}
