
using Microsoft.AspNetCore.Mvc;

namespace TickIT.Controllers
{
    public class AccountController : Controller
    {
        // Displays the login page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // Displays the registration page
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
