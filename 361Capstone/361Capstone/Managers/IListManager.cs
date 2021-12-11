using System;
using System.Collections.Generic;
using _361Capstone.Models;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    interface IListManager
    {
        void InsertCartProduct(int cartId, int productId, int quantity);
        void RemoveCartProduct(int cartId, int productId);
        void ChangeCartProductQuantity(int cartId, int productId, int newQuantity);
        List<string> GetProductInfo(int productId);
        //Cart GetCart(int IdCart);
    }
}
