using _361Capstone.Models;
using _361Capstone.Managers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace _361Capstone.Controllers
{
    public class CheckoutController : Controller
    {
        private UserCartManager userCartManager { get; set; } = new UserCartManager();
        private CheckoutManager checkoutManager = new CheckoutManager();
        private SessionManager SessionMgr { get; set; } = new SessionManager();

        // Returns the checkout page to the client, where users can see what products
        // are in their cart and how much they need to spend to compelte the transaction.
        public IActionResult Index(int userId) {
            //Validates the session to ensure lists can only be edited by the user they belong to.
            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            List<Product> productList = userCartManager.GetUserCartProducts(userId);
            Address address = checkoutManager.GetAddress(userId);
            PaymentInfo paymentInfo = checkoutManager.GetPaymentInfo(userId);  

            if(address.GetAddressId() == 0 || paymentInfo.GetPaymentInfoId() == 0) {
                return RedirectToAction("Index", "InsertData", new { userId });
            }

            double subtotal = 0;
            foreach(Product product in productList) {
                subtotal += product.GetPrice()*product.GetStockCount();
            }

            string tempcardNum = paymentInfo.GetCardNumber();
            string safeCardNum = "";

            for(int i=0;i<tempcardNum.Length;i++) {
                if(i < tempcardNum.Length-4) {
                    safeCardNum += "*";
                } else {
                    safeCardNum += tempcardNum[i];
                }
            }

            ViewData["Products"] = productList;
            ViewData["UserId"] = userId;
            ViewData["CreditCardNumber"] = safeCardNum;
            ViewData["ExpirationMonth"] = paymentInfo.GetExpirationMonth();
            ViewData["ExpirationYear"] = paymentInfo.GetExpirationYear();
            ViewData["CVVCode"] = paymentInfo.GetCvv();
            ViewData["Street"] = address.GetStreet();
            ViewData["City"] = address.GetCity();
            ViewData["State"] = address.GetState();
            ViewData["ZipCode"] = address.GetZipCode();
            ViewData["Country"] = address.GetCountry();
            ViewData["Subtotal"] = subtotal;
            ViewData["TotalProducts"] = productList.Count;

            return View();
        }

        // When the complete transaction button is clicked, this script is run
        // that completes the transaction and tells the database to decrement
        // the necessary product stock counts.
        public IActionResult CompleteTransaction(int userId) {
            checkoutManager.CompleteTransaction(userId);
            return RedirectToAction("Index", "UserCart", new { userId, removedItem = 0, transactionStatus = 1 });
        }

    }
}
