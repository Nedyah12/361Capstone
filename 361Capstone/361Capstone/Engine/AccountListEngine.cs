﻿using System;
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
        CartAccessor CartAccessor { get; set; } = new CartAccessor();
        CartProductAccessor accessor { get; set; } = new CartProductAccessor();

        public string getUser(int userId)
        {
            return UserAccessor.GetUsername(userId);
        }

        public void InsertCart(int userId)
        {
            Cart cart;

            try
            {

            }
            catch (ArgumentNullException)
            {
                return;
            }

            CartAccessor.InsertCart(userId);
            return;

        }
    }
}
