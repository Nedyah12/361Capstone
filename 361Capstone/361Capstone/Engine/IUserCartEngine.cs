using _361Capstone.Models;
using System;
using System.Collections.Generic;

namespace _361Capstone.Engine
{
    public interface IUserCartEngine
    {
         List<List<String>> GetUserCartProductInfo(int userId);
    }
}