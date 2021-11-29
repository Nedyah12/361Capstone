using System;
using OnlineStore.Accessors;
using  _Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    public class LoginEngine : ILoginEngine
    {
        private UserAccessor accessor;

        public LoginEngine()
            {
            accessor = new UserAccessor();
            }

        
    }
}
