using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public interface ICart
    {   
        int GetCartId();
        int GetUserId();

        List<CartProduct> GetCartProducts();
    }
}
