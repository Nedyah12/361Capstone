using System;
using _361Capstone.Models;
using _Capstone.Manager;
using _Capstone.Engine;
using OnlineStore.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class AccountListController : Controller
    {
        private AccountListManager Manager { get; set; } = new AccountListManager();

        public ActionResult Index(int userId)
        {

            User user = Manager.GetUsers(userId);

            ViewData["UserId"] = userId;
            ViewData["Carts"] = user.GetCartId();
            return View();
        }

        //method to add a cart to the database

        //method to remove a cart from the database

        
    }
}
