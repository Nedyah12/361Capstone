using System;
using _361Capstone.Models;
using _Capstone.Manager;
using _Capstone.Engine;
using OnlineStore.Accessors;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class CartController : Controller
    {
        private LoginManager LoginManager { get; set; } = new LoginManager();
        private ListManager ListManager { get; set; } = new ListManager();

        public ActionResult Index(int CartId)
        {
            Cart cart = ListManager.GetCart(CartId);
            int UserId = cart.getUserId();

            //Should we authenticate the login?

            ViewData["UserId"] = cart.getUserId();
            //GetProducts in cart model? 
            ViewData["Products"] = 
            ViewData["CartId"] = CartId;

            return View();
        }
        
        public ActionResult Add(int ProductId, int CartId)
        {
            Cart cart = ListManager.GetCart(CartId);
            int userId = cart.getUserId();
            //Authenticate Login

            //Product product = new Product();??
            ListManager.AddProducts(product);

            return RedirectToAction("Index", new { CartId });
        }

        public ActionResult Edit(int CartId, int ProductId, string NewProduct)
        {

        }

        public ActionResult Delete(int ProductId, int CartId)
        {
            Cart cart = ListManager.GetCart(CartId);
            int userId = cart.getUserId();
            //Authenticate Login

            //Product poduct = new Product();???
            ListManager.RemoveProduct(product);

        }
        

        
       
    }
}
