using _361Capstone.Accessors;
using _361Capstone.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers {
    public class LoginController : Controller {
        // Returns the default index page for the login page.
        public IActionResult Index(bool incorrectUsername = false, bool incorrectPassword = false) {
            ViewData["IncorrectUsername"] = incorrectUsername;
            ViewData["IncorrectPassword"] = incorrectPassword;
            return View();
        }

        // Routes the user to the products page if the login is successful.
        public IActionResult Success(int userId) {
            string key = userId.ToString();
            HttpContext.Session.SetString("_Key", key);
            return RedirectToAction("Index", "Products", new { userId });
        }

        // The login information the user specifies is confirmed against the
        // database when this is fired.
        public IActionResult AuthenticateUser(string username, string password) {
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

        // When run, the user is logged out and the session key is cleared.
        public IActionResult Logout() {
            HttpContext.Session.SetString("_Key", "");
            return RedirectToAction("Index");
        }
    }
}