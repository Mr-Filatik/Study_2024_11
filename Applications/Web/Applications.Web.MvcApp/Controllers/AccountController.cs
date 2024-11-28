using Applications.Web.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Applications.Web.MvcApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login", new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Login == "Vlad" && model.Password == "1234")
            {
                return View("Account", new AccountViewModel() 
                { 
                    Guid = Guid.NewGuid().ToString(), 
                    Name = "Vlad", 
                    FriendNames = new List<string>() { "qsfgs", "csvhc", "csvhsk" } 
                });
            }
            return View("Login", model);
        }

        [HttpGet]
        public IActionResult Account(string guid)
        {
            var str = Guid.NewGuid().ToString();
            return View("Account", new AccountViewModel()
            { 
                Guid = str, 
                Name = str , 
                FriendNames = new List<string>() { "qsfgs", "csvhc", "csvhsk"}
            });
        }

        public IActionResult Logout()
        {
            return View("Login");
        }
    }
}
