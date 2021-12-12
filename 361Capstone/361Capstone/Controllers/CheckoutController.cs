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
    public class CheckoutController : Controller
    {
        private UserCartManager userCartManager { get; set; } = new UserCartManager();
        private CheckoutManager checkoutManager = new CheckoutManager();
        private SessionManager SessionMgr { get; set; } = new SessionManager();
        public IActionResult Index(int userId) {
            //Validates the session to ensure lists can only be edited by the user they belong to.
            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            List<Product> productList = userCartManager.GetUserCartProducts(userId);
            Address address = checkoutManager.GetAddress(userId);
            PaymentInfo paymentInfo = checkoutManager.GetPaymentInfo(userId);


            ViewData["Products"] = productList;
            ViewData["UserId"] = userId;
            ViewData["CreditCardNumber"] = paymentInfo.GetCardNumber();
            ViewData["ExpirationMonth"] = paymentInfo.GetExpirationMonth();
            ViewData["ExpirationYear"] = paymentInfo.GetExpirationYear();
            ViewData["CVVCode"] = paymentInfo.GetCvv();
            ViewData["Street"] = address.GetStreet();
            ViewData["City"] = address.GetCity();
            ViewData["State"] = address.GetState();
            ViewData["ZipCode"] = address.GetZipCode();
            ViewData["Country"] = address.GetCountry();

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
