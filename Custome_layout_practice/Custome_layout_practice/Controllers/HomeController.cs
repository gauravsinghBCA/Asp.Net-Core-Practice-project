using Microsoft.AspNetCore.Mvc;

namespace Custome_layout_practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
