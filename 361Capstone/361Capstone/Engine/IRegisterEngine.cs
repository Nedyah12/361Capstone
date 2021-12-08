﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine
{
    interface IRegisterEngine
    {
        void AuthenticateLogin(string username, string password);
        int AddUsers(string username, string password);
    }
}
