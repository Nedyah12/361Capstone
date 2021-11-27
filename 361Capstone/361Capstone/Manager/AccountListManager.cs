using System;
using _361Capstone.Models;
using _Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    public class AccountListManager : IAccountListManager
    {
        AccountListEngine Manager { get; set; } = new AccountListEngine();

        public void AddList(List list)
        {
            Manager.AddList(list);
            return;


        }

        public void changeEmail(int IdUser, string newEmail)
        {
            Manager.changeEmail(IdUser, newEmail);
            return;
        }

        public Users GetUsers(int IdUser)
        {
            return Manager.GetUsers(IdUser);
        }

        public void RemoveList(int IdList)
        {
            Manager.RemoveList(IdList);
            return;
        }

    }
}
