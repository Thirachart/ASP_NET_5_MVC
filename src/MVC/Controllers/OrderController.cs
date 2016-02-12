using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Mockup.DAL;
using DAL;

namespace MVC.Controllers
{
    public class OrderController : Controller
    {
        public OrderController()
        {

        }

        public IActionResult Index()
        {
            IOrderRepository rep = new OrderRepository();
            return View(rep.GetOrders());
        }
    }
}
