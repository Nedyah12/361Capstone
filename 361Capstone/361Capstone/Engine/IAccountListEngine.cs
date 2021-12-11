using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    interface IAccountListEngine
    {
        string getUser(int userId);
        void InsertCart(int userId);
        //We need to remove Cart or is it going to be removed when we get rid off the products in ListEngine ??
        
    }
}
