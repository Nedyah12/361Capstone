using _361Capstone.Engine;
using _361Capstone.Accessors;
using Microsoft.AspNetCore.Mvc;

namespace _361Capstone.Controllers
{
    public class RegistrationController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AuthenticateInput(string username, string password)
        {
            AuthenticationEngine engine = new AuthenticationEngine();
            UserAccessor user = new UserAccessor();


            bool correctPassword = engine.AuthenticatePassword(password);
            bool correctUsername = engine.AuthenticateUser(username);

            if (correctPassword && correctUsername)
            {
                int userId = user.InsertUser(username, password);
                return RedirectToAction("Index", "Login");
            } else {
                return RedirectToAction("Index");
            }

            
        }
    }
}
