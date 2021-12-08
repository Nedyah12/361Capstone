using System;
using _361Capstone.Models;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    public class AccountListEngine : IAccountListEngine
    {
        //Accessor here
        UserAccessor UserAccessor { get; set; } = new UserAccessor();
        //CartAccessor CartAccessor { get; set; } = new CartAccessor();
        //CartProductAccessor accessor { get; set; } = new CartProductAccessor(); ??

        public User getUser(int userId)
        {
            throw new NotImplementedException();
        }

        /*public void AddList(List list)
        
        public void RemoveList(int IdList)
        {
            throw new NotImplementedException();
        }*/

        /*
         public void InsertCart(int userId)
         {

         }
        */

        /*
        public void InsertCartProduct(int cartId, int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public void RemoveCartProduct(int cartId, int productId)
        {
            throw new NotImplementedException();
        }
        */

    }
}
