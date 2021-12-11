
using _361Capstone.Models;
using System;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class ListEngine : IListEngine
    {
        CartAccessor CartAccessor { get; set; } = new CartAccessor();
        CartProductAccessor Accessor { get; set; } = new CartProductAccessor();
        ProductAccessor ProductAccessor { get; set; } = new ProductAccessor();

        public ListEngine()
        {
            Accessor = new CartProductAccessor();
            ProductAccessor = new ProductAccessor();
        }

        public Cart GetCart(int cartId)
        {

            
        }

        public void ChangeCartProductQuantity(int cartId, int productId, int newQuantity)
        {
            try
            {
                Accessor.ChangeCartProductQuantity(cartId, productId, newQuantity);
            }
            catch (ArgumentNullException)
            {
                return;
            }

            return;
        }

        public List<string> GetProductInfo(int productId)
        {
            return ProductAccessor.GetProductInfo(productId);
        }

        public void InsertCartProduct(int cartId, int productId, int quantity)
        {

        }

        public void RemoveCartProduct(int cartId, int productId)
        {
            try
            {
                Accessor.RemoveCartProduct(cartId, productId);
            }
            catch (ArgumentNullException)
            {
                return;
            }

            return;
        }
    }
}
