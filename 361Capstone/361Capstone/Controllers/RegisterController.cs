using System;
using _361Capstone.Models;
using _361Capstone.Manager;
using _361Capstone.Engine;
using _361Capstone.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthenticateLogin(string username, string password)
        {
            AuthenticationEngine engine = new AuthenticationEngine();

            UserAccessor user = new UserAccessor();


            bool correctPassword = engine.AuthenticatePassword(password);
            bool correctUsername = engine.AuthenticateUser(username);

            if (correctPassword && correctUsername)
            {
                int userId = AddUsers(username, password);
                return RedirectToAction("Index", "Login");
            } else {
                return RedirectToAction("Index");
            }

            //I need the Security manager to secure password and then add the user
            // to the database
            
        }
        public int AddUsers(string username, string password) {
            UserAccessor userAccessor = new UserAccessor();
            return userAccessor.insertUser(username, password);
        }
    }
}
