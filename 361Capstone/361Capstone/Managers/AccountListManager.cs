using System;
using _361Capstone.Models;
using _361Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    public class AccountListManager : IAccountListManager
    {
        AccountListEngine Engine { get; set; } = new AccountListEngine();


        public string getUser(int IdUser)
        {
            return Engine.getUser(IdUser);
        }

        public void InsertCart(int userId)
        {
            Engine.InsertCart(userId);
            return;
        }

    }
}






