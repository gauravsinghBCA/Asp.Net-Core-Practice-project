using List_Data_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace List_Data_Model.Controllers
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

        public IActionResult Showdata()
        {
            List<Student> student = new List<Student>()
            {
                new Student(){ stid=1,stname="Gaurav", stage=22,stcourse="Asp.net" },
                new Student(){ stid=2,stname="Ritest", stage=23,stcourse="Python" },
                new Student(){ stid=3,stname="Jishu", stage=25,stcourse="Java" },
                new Student(){ stid=4,stname="Adarsh", stage=24,stcourse="C#" },
                new Student(){ stid=5,stname="Monu", stage=25,stcourse="C++" }
            };
            return View(student);
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
