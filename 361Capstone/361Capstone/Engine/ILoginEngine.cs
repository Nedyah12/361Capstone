﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Engine
{
    interface ILoginEngine
    {
        void AutheticateLogin(string email, string password);
        int AnotherUser(string email, string password);
    }
}