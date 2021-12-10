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
    public class ProductDetailsController : Controller
    {
        ProductsManager manager = new ProductsManager();

        public IActionResult Index(int productId) {
            //Retrieves the list from the database.
            Product product = manager.GetProduct(productId);

            //Validates the session to ensure lists can only be edited by the user they belong to.
            /*string key = HttpContext.Session.GetString("_Key");
            if (!Sessionmgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }*/


            ViewData["ProductName"] = product.GetName();
            ViewData["Description"] = product.GetDescription();
            ViewData["ManInfo"] = product.GetManInfo();
            ViewData["Dimensions"] = product.GetDimensions();
            ViewData["Weight"] = product.GetWeight();
            ViewData["Rating"] = product.GetRating();
            ViewData["StockCount"] = product.GetStockCount();


            //ViewData["Products"] = list;
            //ViewData["ItemCount"] = list.Count();
            //ViewData["Categories"] = categories;
            //ViewData["ListId"] = listId;
            ViewData["Title"] = product.GetName();
            //ViewData["UserId"] = list.GetUserId();

            return View();
        }


    }
}
