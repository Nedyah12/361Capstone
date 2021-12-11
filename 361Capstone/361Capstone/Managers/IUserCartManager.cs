using _361Capstone.Models;
using System.Collections.Generic;

namespace _361Capstone.Managers
{
    public interface IUserCartManager
    {
        List<Product> GetUserCartProducts(int userId);
    }
}