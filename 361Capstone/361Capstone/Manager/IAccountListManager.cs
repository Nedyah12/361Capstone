using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    public interface IAccountListManager
    {
        Users GetUsers(int IdUser);
        void changeEmail(int IdUser, string newEmail);
        void AddList(List list);
        void RemoveList(int IdList);
    }
}
