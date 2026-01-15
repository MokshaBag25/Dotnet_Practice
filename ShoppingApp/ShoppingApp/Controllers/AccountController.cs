using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Models;

namespace ShoppingApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.UserName == "Admin@Name" && model.Password == "Admin@123")
            {
                HttpContext.Session.SetString("UserName", model.UserName);
                return RedirectToAction("Index", "Orders");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }

    }
}
