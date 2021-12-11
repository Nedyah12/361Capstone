using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _361Capstone.Accessors;
using _361Capstone.Managers;
using _361Capstone.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class UserCartController : Controller
    {
        private UserCartManager Manager { get; set; } = new UserCartManager();
        private SessionManager SessionMgr { get; set; } = new SessionManager();

        //Displays a page listing all of the user's grocery lists.
        public IActionResult Index(int userId)
        {
            /*string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId))
            {
                return RedirectToAction("Logout", "Login");
            }*/

            //User user = Manager.GetUser(userId);
            List<Product> productList = Manager.GetUserCartProducts(userId);

            ViewData["Products"] = productList;
            ViewData["UserId"] = userId;
            ViewData["ListCount"] = productList.Count;
            return View();
        }

        //Retrieves values from an HTML form to add a new list to the database.
        public IActionResult Add(string title, int userId)
        {
            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId))
            {
                return RedirectToAction("Logout", "Login");
            }

            //SportsItemList list = new SportsItemList(title, userId);
            //Manager.AddList(list);

            //Returns to the Index page after the list has been added.
            return RedirectToAction("Index", new { userId });
        }

        //Removes a list from the database.
        public IActionResult Remove(int listId, int userId)
        {
            string key = HttpContext.Session.GetString("_Key");

            if (!SessionMgr.ValidateKey(key, userId))
            {
                return RedirectToAction("Logout", "Login");
            }

           // Manager.RemoveList(listId);
            //Returns to the Index page after the item has been removed.
            return RedirectToAction("Index", new {userId});
        }
    }
}