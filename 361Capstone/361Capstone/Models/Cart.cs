using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public class Cart
    {   //TODO: is this all that is needed for cart?
        //TODO: add cartItem model ?
        /*only 2 items in database, user has
        the cart, cartItem should have the items?*/
        private int CartId { get; set; }
        private int UserId { get; set; }

        //private long IdList { get; set; }
        //private string Title { get; set; }
        //private List<Products> products { get; set; }

        public Cart(int userId, int cartId)
        {
            UserId = userId;
            CartId = cartId;
        }
        public int GetCartId()
        {
            return CartId;
        }
        public int getUserId()
        {
            return UserId;
        }
    }
}
