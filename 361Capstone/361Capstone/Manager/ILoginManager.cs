﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Capstone.Manager
{
    interface ILoginManager
    {
        bool AuthenticateLogin(string Login, int IdUser);
    }
}