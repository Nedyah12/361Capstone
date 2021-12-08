using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    interface IAccountListEngine
    {
        User getUser(int userId);
        void RemoveList(int IdList);
        //void InsertCartProduct(int cartId, int productId, int quantity);
        //void RemoveCartProduct(int cartId, int productId);
        // void InsertCart(int userId);
    }
}
