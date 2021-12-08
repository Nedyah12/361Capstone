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

        /*public void AddList(List list)
        {
            throw new NotImplementedException();
        }*/

        public User GetUser(int IdUser)
        {
            throw new NotImplementedException();
        }

        public void RemoveList(int IdList)
        {
            throw new NotImplementedException();
        }
    }
}
