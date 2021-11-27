using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    interface IListEngine
    {
        Products AddProducts(Products product);
        bool Exist(Products product);
        List GetList(int IdList);
        void EditProduct(Products products, string newElement);
        void RemoveProduct(Products product);

    }
}
