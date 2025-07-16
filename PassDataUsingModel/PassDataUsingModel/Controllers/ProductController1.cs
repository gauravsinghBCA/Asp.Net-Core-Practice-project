using Microsoft.AspNetCore.Mvc;
using PassDataUsingModel.Models;

namespace PassDataUsingModel.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ShowData(Product pro)
        {

            ViewBag.name = pro.pname;
            ViewBag.code = pro.pcode;
            return View();
        }
    }
}
