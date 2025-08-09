using Microsoft.AspNetCore.Mvc;
using PassDataUsingFormCollection.Models;
using System.Diagnostics;

namespace PassDataUsingFormCollection.Controllers
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
            return View();
        }

        public IActionResult ShowData(IFormCollection data)
        {
            ViewBag.sname = data["sname"];
            ViewBag.scourse = data["scourse"];
            ViewBag.sdob = data["sdob"];
            ViewBag.gender = data["gender"];

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
