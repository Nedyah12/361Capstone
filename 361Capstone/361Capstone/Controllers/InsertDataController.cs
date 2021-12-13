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
        private InsertDataManager manager = new InsertDataManager();
        public IActionResult Index(int userId) {

            string key = HttpContext.Session.GetString("_Key");
            if (!SessionMgr.ValidateKey(key, userId)) {
                return RedirectToAction("Logout", "Login");
            }

            ViewData["UserId"] = userId;


            return View();
        }

        public IActionResult SendData(int userId, int ccn, int expm, int expy, 
                                      int cvv, string street, string city, string state, 
                                      int zip, string country) {


            return RedirectToAction("Index", "Checkout", new { userId });
        }

    }
}