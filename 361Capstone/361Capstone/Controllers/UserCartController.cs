using System.Collections.Generic;
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

        // Returns the view with information about a specific user's cart.
        public IActionResult Index(int userId, int removedItem, int transactionStatus)
        {
            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId))
            {
                return RedirectToAction("Logout", "Login");
            }

            List<Product> productList = Manager.GetUserCartProducts(userId);

            ViewData["Products"] = productList;
            ViewData["UserId"] = userId;
            ViewData["ListCount"] = productList.Count;
            ViewData["RemovedItem"] = removedItem;
            ViewData["Transaction"] = transactionStatus;
            return View();
        }

        // The 'Remove' button runs this scipt that removes an item
        // from a user's cart.
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