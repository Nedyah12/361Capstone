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
        public IActionResult Index(int userId, int removedItem)
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
            ViewData["RemovedItem"] = removedItem;
            return View();
        }

        //Retrieves values from an HTML form to add a new list to the database.
        public IActionResult RemoveItemFromCart(int userId, int productId) {
            CartProductAccessor accessor = new CartProductAccessor();
            int removedItem = 0;

            bool returnVal = accessor.RemoveCartProduct(userId, productId);

            if (returnVal) {
                removedItem = 1;
            } else {
                removedItem = -1;
            }

            return RedirectToAction("Index", new { productId, userId, removedItem });
        }
    }
}