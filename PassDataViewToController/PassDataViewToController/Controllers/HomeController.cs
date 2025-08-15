using Microsoft.AspNetCore.Mvc;
using PassDataViewToController.Models;
using System.Diagnostics;

namespace PassDataViewToController.Controllers
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
        
        public IActionResult FillForm()
        {

            return View();
        }

        public IActionResult ShowData(string nam,string add,string cors)
        {
            ViewBag.Name = nam;
            ViewBag.Add = add;
            ViewBag.Cors = cors;
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
