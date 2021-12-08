﻿using System;
using _361Capstone.Models;
using _361Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Manager
{
    public class AccountListManager : IAccountListManager
    {
        AccountListEngine Manager { get; set; } = new AccountListEngine();

        /*public void AddList(List list)
        {
            Manager.AddList(list);
            return;


        }*/

        public User GetUsers(int IdUser)
        {
            return Manager.GetUser(IdUser);
        }

        public void RemoveList(int IdList)
        {
            Manager.RemoveList(IdList);
            return;
        }

    }
}
