using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _361Capstone.Accessors;
using _361Capstone.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _361Capstone.Models;

namespace _SportsStore.Controllers {
    public class LoginController : Controller {
        public IActionResult Index(bool incorrectUsername = false, bool incorrectPassword = false) {
            ViewData["IncorrectUsername"] = incorrectUsername;
            ViewData["IncorrectPassword"] = incorrectPassword;
            return View();
        }

        //Redirects to the page displaying the user's lists upon a sucessful login.
        public IActionResult Success(int userId) {
            string key = userId.ToString();
            HttpContext.Session.SetString("_Key", key);
            //return RedirectToAction("Index", "Products", new { userId });
            return RedirectToAction("Index", "Products", new { userId });
        }

        public IActionResult AuthenticateUser(string username, string password) {
            //These are used to display a popup if a user tries to login with an incorrect email or password.
            bool incorrectUsername = false;
            bool incorrectPassword = false;

            UserAccessor userAccessor = new UserAccessor();

            if (username == null) {
                incorrectUsername = true;
                return RedirectToAction("Index", new { incorrectUsername, incorrectPassword });
            } else if (password == null) {
                incorrectPassword = true;
                return RedirectToAction("Index", new { incorrectUsername, incorrectPassword });
            }
            /*
             * Sees whether or not the email is connected to a user in the database.
             * If yes, tests whether the password matches the one in the database.
             * The database password will have to be decrypted.  If the password is correct,
             * redirect to Success(userId).  If the email or password are not correct, redirect to Index().
             * We should have it show an error message, and I think this can be flagged using TempData[],
             * but I haven’t tested it out.
             */
            //EncryptionManager em = new EncryptionManager();
            LoginManager manager = new LoginManager();
            bool login = userAccessor.ValidateUserInfo(username, password);
            int userId = manager.CheckUsername(username);

            if (login) {
                return RedirectToAction("Success", new { userId });
            } else {
                return RedirectToAction("Index", new { incorrectUsername, incorrectPassword });
            }

       
            incorrectUsername = true;
            return RedirectToAction("Index", new { incorrectUsername, incorrectPassword });
        }

        public IActionResult Logout() {
            HttpContext.Session.SetString("_Key", "");
            return RedirectToAction("Index");
        }
    }
}