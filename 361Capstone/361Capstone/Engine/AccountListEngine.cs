using System;
using _361Capstone.Models;
using OnlineStore.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    public class AccountListEngine : IAccountListEngine
    {

        //Accessor here
        UserAccessor UserAccessor { get; set; } = new UserAccessor();

        public void AddList(List list)
        {
            throw new NotImplementedException();
        }

        public Users GetUsers(int IdUser)
        {
            throw new NotImplementedException();
        }

        public void RemoveList(int IdList)
        {
            throw new NotImplementedException();
        }
    }
}
