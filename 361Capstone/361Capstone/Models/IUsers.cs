using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public interface IUsers
    {
        string GetUserId();
        string GetPassword();
        int Total();
        void AddList(List list);
        List<List> GetLists();

    }
}
