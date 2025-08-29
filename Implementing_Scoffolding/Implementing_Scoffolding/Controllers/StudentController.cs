using Microsoft.AspNetCore.Mvc;
using System.Data;
using Implementing_Scoffolding.Models;

namespace Implementing_Scoffolding.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> student = new List<Student>()
            {
                new Student(){ stid=1,stname="Gaurav Singh",stage= new DateTime(2002,09,12), emailid="Gaurav@gmail.com",gender="Male"},
                new Student(){ stid=1,stname="Gaurav Singh",stage= new DateTime(2002,09,12), emailid="Gaurav@gmail.com",gender="Male"},
                new Student(){ stid=1,stname="Gaurav Singh",stage= new DateTime(2002,09,12), emailid="Gaurav@gmail.com",gender="Male"},
                new Student(){ stid=1,stname="Gaurav Singh",stage= new DateTime(2002,09,12), emailid="Gaurav@gmail.com",gender="Male"},
                new Student(){ stid=1,stname="Gaurav Singh",stage= new DateTime(2002,09,12), emailid="Gaurav@gmail.com",gender="Male"}
            };
            return View(student);
        }
    }
}
