
using _361Capstone.Models;
using System;
using OnlineStore.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    public class ListEngine : IListEngine
    {
        CartProductAccessor Accessor { get; set; } = new CartProductAccessor();
        ProductAccessor ProductAccessor { get; set; } = new ProductAccessor();

        public void ChangeCartProductQuantity(int cartId, int productId, int newQuantity)
        {
            throw new NotImplementedException();
        }

        public List<string> GetProductInfo(int productId)
        {
            throw new NotImplementedException();
        }

        public void InsertCartProduct(int cartId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveCartProduct(int cartId, int productId)
        {
            throw new NotImplementedException();
        }
    }
}
