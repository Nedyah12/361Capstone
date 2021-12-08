using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Engine {
    interface ILoginEngine { 
     public int CheckUsername(string username);
     public string RetrievePassword(int userId);
    }
}
