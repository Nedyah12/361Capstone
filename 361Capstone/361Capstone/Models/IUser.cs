using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Models
{
    public interface IUser
    {
        int GetUserId();
        string GetUsername();
        string GetPassword();

        //Include this correct??
        int GetCartId();
        //Are we allowing multiple carts?
        //void AddList(List list);
        //List<List> GetLists();

    }
}
