using System;
using _361Capstone.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    interface IAccountListEngine
    {
        Users GetUsers(int IdUser);
        void AddList(List list);
        void RemoveList(int IdList);
    }
}
