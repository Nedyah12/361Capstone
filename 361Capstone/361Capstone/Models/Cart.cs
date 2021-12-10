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


        public List<CartProduct> GetCartProducts()
        {
            return CartProducts;
        }

        public Cart(int userId, int cartId)
        {
            UserId = userId;
            CartId = cartId;
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
