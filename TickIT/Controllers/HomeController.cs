using Microsoft.AspNetCore.Mvc;

namespace TickIT.Controllers   // <-- change to match your project's namespace
{
    public class HomeController : Controller
    {
        public IActionResult Landing() => View();
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult Privacy() => View();
    }
}
