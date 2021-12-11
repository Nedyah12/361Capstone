using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Cart : ICart
    {
        private int CartId { get; set; }
        private int UserId { get; set; }

        //list of items
        private List<CartProduct> CartProducts { get; set; }


        public Cart(int userId, int cartId)
        {
            UserId = userId;
            CartId = cartId;
        }
        public Cart(int userId, int cartId, List<CartProduct> products)
        {
            UserId = userId;
            CartId = cartId;
            CartProducts = products;
        }
        public List<CartProduct> GetCartProducts()
        {
            return CartProducts;
        }
        public int GetCartId()
        {
            return CartId;
        }
        public int GetUserId()
        {
            return UserId;
        }
    }
}
