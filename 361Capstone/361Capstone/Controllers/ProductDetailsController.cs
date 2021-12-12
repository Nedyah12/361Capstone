using System;
using _361Capstone.Models;
using _361Capstone.Managers;
using _361Capstone.Engine;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _361Capstone.Controllers
{
    public class ProductDetailsController : Controller
    {
        ProductsManager manager = new ProductsManager();

        public IActionResult Index(int productId, int userId, int addedItem) {
            //Retrieves the list from the database.
            Product product = manager.GetProduct(productId);

            //Validates the session to ensure lists can only be edited by the user they belong to.
            SessionManager Sessionmgr = new SessionManager();
            string key = HttpContext.Session.GetString("_Key");
            if (!Sessionmgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            ViewData["Title"] = product.GetName();
            ViewData["ProductName"] = product.GetName();
            ViewData["Description"] = product.GetDescription();
            ViewData["ManInfo"] = product.GetManInfo();
            ViewData["Dimensions"] = product.GetDimensions();
            ViewData["Weight"] = product.GetWeight();
            ViewData["Rating"] = product.GetRating();
            ViewData["StockCount"] = product.GetStockCount();
            ViewData["UserId"] = userId;
            ViewData["ProductId"] = product.GetProductId();
            ViewData["AddedItem"] = addedItem;
            ViewData["Price"] = product.GetPrice();

            return View();
        }

        public IActionResult AddItemToCart(int userId, int productId, int count) {
            CartProductAccessor accessor = new CartProductAccessor();
            int addedItem = 0;

            bool returnVal = accessor.InsertCartProduct(userId, productId, count);

            if(returnVal) {
                addedItem = 1;
            } else {
                addedItem = -1;
            }

            return RedirectToAction("Index", new { productId, userId, addedItem });
        }

    }
}
