using Microsoft.AspNetCore.Mvc;
using System;
using _361Capstone.Models;
using _Capstone.Manager;
using _Capstone.Engine;
using OnlineStore.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _361Capstone.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index(bool incorrectPassword = false, bool incorrectUsername = false)
        {
            ViewData["IncorrectPassword"] = incorrectPassword;
            ViewData["IncorrectUsername"] = incorrectUsername;
            return View();
        }

        public ActionResult SuccessfulLogin(int userId)
        {

        }

        public ActionResult AuthenticateUser(string username, string password)
        {
            bool incorrectPassword = false;
            bool incorrectUsername = false;

            if (password == null)
            {
                incorrectPassword = true;
                return RedirectToAction("Index", new { incorrectPassword, incorrectUsername });
            }

            else if (username == null)
            {
                incorrectUsername = true;
                return RedirectToAction("Index", new { incorrectPassword, incorrectUsername });
            }

            //need the security manager to handle passwords
            return RedirectToAction("Index", new { incorrectPassword, incorrectUsername });
        }

        public ActionResult Logout()
        {
            //Should have Login manager ready to implement this
            
            
        }
    }
}
