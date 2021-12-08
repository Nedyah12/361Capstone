using System;
using _361Capstone.Models;
using _361Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Manager
{
    public class ListManager : IListManager
    {
        ListEngine Engine { get; set; } = new ListEngine();

        public Product AddProducts(Product product)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Product products, string newElement)
        {
            throw new NotImplementedException();
        }

        public bool Exist(Product product)
        {
            throw new NotImplementedException();
        }

        public Cart GetCart(int IdCart)
        {
            throw new NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
