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
        IOrderRepository orderRepository;
        public OrderController(IOrderRepository rep)
        {
            orderRepository = rep;
        }

        public IActionResult Index()
        {
            return View(orderRepository.GetOrders());
        }
    }
}
