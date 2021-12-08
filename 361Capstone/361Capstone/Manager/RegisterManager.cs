﻿using System;
using _361Capstone.Engine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Manager
{
    public class RegisterManager : IRegisterManager
    {
        RegisterEngine Manager { get; set; } = new RegisterEngine();

        public int AddUsers(string username, string password)
        {
            return Manager.AddUsers(username, password);
        }

        public void AuthenticateLogin(string username, string password)
        {
            Manager.AuthenticateLogin(username, password);
            return;
        }
    }
}
