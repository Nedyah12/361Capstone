using System;
using _361Capstone.Models;
using _361Capstone.Managers;
using _361Capstone.Engine;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class ProductsController : Controller
    {
        readonly ProductsManager manager = new ProductsManager();

        public IActionResult Index() {
            //Retrieves the list from the database.
            List<Product> list = manager.GetAllStoreProducts();
            List<Category> categories = manager.GetAllCategories();
            //int userId = list.GetUserId();

            //Validates the session to ensure lists can only be edited by the user they belong to.
            /*string key = HttpContext.Session.GetString("_Key");
            if (!Sessionmgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }*/

            ViewData["Products"] = list;
            ViewData["ItemCount"] = list.Count();
            ViewData["Categories"] = categories;
            //ViewData["ListId"] = listId;
            ViewData["Title"] = "Store Products";
            //ViewData["UserId"] = list.GetUserId();

            return View();
        }

        public IActionResult GoToProductPage(int productId) {
            //string key = userId.ToString();
            //HttpContext.Session.SetString("_Key", key);
            return RedirectToAction("Index", "ProductDetails", new { productId });
        }


    }
}
