using Microsoft.AspNetCore.Mvc;
using Strongly_HtmoHelpper.Models;

namespace Strongly_HtmoHelpper.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            Student s = new Student() { sname = "Gaurav", pass = "12" };
            return View(s);
        }

        public string ShowData(Student s)
        {
            return s.sname + "  " + s.pass; 
        }
    }
}
