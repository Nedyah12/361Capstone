using _361Capstone.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers {
    public class InsertDataController : Controller {
        private SessionManager SessionMgr { get; set; } = new SessionManager();
        private InsertDataManager manager = new InsertDataManager();

        // Returns the default index page to the page where users
        // must input payment and address info to be tied to their account.
        public IActionResult Index(int userId) {

            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            ViewData["UserId"] = userId;


            return View();
        }

        // When fired, this script sends the data inserted by the user on the
        // page to the database to be tied to their account.
        public IActionResult SendData(int userId, string ccn, int expm, int expy, 
                                      int cvv, string street, string city, string state, 
                                      int zip, string country) {

            manager.SendPaymentInfo(userId, ccn, expm, expy, cvv);
            manager.SendAddress(userId, street, city, state, zip, country);
            return RedirectToAction("Index", "Checkout", new { userId });
        }

    }
}