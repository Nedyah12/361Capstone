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
        AccountListEngine Manager { get; set; } = new AccountListEngine();

        /*
        public void AddList(List list)
        {
            Manager.AddList(list);
            return;


        }
        */
        /*public User GetUser(int IdUser)
        {
            return Manager.getUser(IdUser);
        }*/

        public void RemoveList(int IdList)
        {
            //Manager.RemoveList(IdList);
            return;
        }

    }
}
