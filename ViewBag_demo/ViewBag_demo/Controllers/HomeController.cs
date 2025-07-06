using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewBag_demo.Models;

namespace ViewBag_demo.Controllers
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
            ViewBag.roll = 1;
            ViewBag.name = "Gaurav Singh";
            ViewBag.course = "Asp.Net";
            ViewBag.fee1 = 500;
            ViewBag.fee2 = 1000;

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
