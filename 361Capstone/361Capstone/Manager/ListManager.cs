using System;
using _361Capstone.Models;
using _Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    public class ListManager : IListManager
    {
        ListEngine Engine { get; set; } = new ListEngine();

        public Products AddProducts(Products product)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Products products, string newElement)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Products product)
        {
            throw new NotImplementedException();
        }

        public List GetList(int IdList)
        {
            return Engine.GetList(IdList);
        }

        public void RemoveProduct(Products product)
        {
            throw new NotImplementedException();
        }
    }
}
