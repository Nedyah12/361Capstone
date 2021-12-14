using _361Capstone.Models;
using _361Capstone.Managers;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _361Capstone.Controllers
{
    public class ProductsController : Controller
    {
        readonly ProductsManager manager = new ProductsManager();

        // Default index page for the full list of products in the database.
        public IActionResult Index(int userId) {
            //Retrieves the list from the database.
            List<Product> list = manager.GetAllStoreProducts();
            List<Category> categories = manager.GetAllCategories();

            //Validates the session to ensure lists can only be edited by the user they belong to.
            SessionManager Sessionmgr = new SessionManager();
            string key = HttpContext.Session.GetString("_Key");
            if (!Sessionmgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            ViewData["Products"] = list;
            ViewData["ItemCount"] = list.Count();
            ViewData["Categories"] = categories;
            ViewData["Title"] = "Store Products";
            ViewData["UserId"] = userId;

            return View();
        }

        // This script sends and end user to the product details page.
        public IActionResult GoToProductPage(int productId, int userId) {
            return RedirectToAction("Index", "ProductDetails", new { productId, userId });
        }


    }
}
