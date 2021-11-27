using System;
using System.Collections.Generic;
using _361Capstone.Models;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    interface IListManager
    {
        Products AddProducts(Products product);
        bool Exist(Products product);
        List GetList(int IdList);
        void EditProduct(Products products, string newElement);
        void RemoveProduct(Products product);
    }
}
