﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Managers
{
    interface ILoginManager
    {
        public int CheckUsername(string username);
        public string RetrievePassword(int userId);
    }
}