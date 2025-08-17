using Microsoft.AspNetCore.Mvc;
using PassDataUsingRequestObj.Models;
using System.Diagnostics;

namespace PassDataUsingRequestObj.Controllers
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

        [HttpPost]
        public IActionResult ShowData()
        {
            ViewBag.sname = Request.Form["sname"];
            ViewBag.scourse = Request.Form["scourse"];
            ViewBag.sdob = Request.Form["sdob"];
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
