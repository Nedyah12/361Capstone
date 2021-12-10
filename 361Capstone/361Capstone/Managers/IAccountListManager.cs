using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    public interface IAccountListManager
    {
        User GetUser(int IdUser);
        //void AddList(List list);
        void RemoveList(int IdList);
    }
}
