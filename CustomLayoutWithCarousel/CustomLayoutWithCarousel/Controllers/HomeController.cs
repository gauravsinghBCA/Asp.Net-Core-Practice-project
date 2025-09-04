using Microsoft.AspNetCore.Mvc;

namespace CustomLayoutWithCarousel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About_Us()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
