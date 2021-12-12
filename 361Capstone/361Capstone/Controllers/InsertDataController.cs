using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _361Capstone.Accessors;
using _361Capstone.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using _361Capstone.Models;

namespace _361Capstone.Controllers {
    public class InsertDataController : Controller {
        private SessionManager SessionMgr { get; set; } = new SessionManager();
        public IActionResult Index(int userId) {

            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }


            return View();
        }

        //Redirects to the page displaying the user's lists upon a sucessful login.

    }
}