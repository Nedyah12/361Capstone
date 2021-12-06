using System;
using System.Collections.Generic;
using _361Capstone.Models;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    interface IListManager
    {
        Product AddProducts(Product product);
        bool Exist(Product product);
        Cart GetCart(int IdCart);
        void EditProduct(Product products, string newElement);
        void RemoveProduct(Product product);
    }
}
