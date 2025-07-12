using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewData_Demo.Models;

namespace ViewData_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["id"] = 1;
            ViewData["name"] = "gaurav";
            ViewData["add"] = "Delhi";
            ViewData["first1"] = 5000;
            ViewData["first2"] = 4000;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
