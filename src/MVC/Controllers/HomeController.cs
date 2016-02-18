using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using BLL;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult About(Order o)
        {
            o.OrderID = 2222;
            return View(o);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            Order o = new Order() { OrderID = 1111 };
            return View(o);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
