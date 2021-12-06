using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAP_T2010A.Models;

namespace WAP_T2010A.Controllers
{
    public class OrderController : Controller
    {
        private DataContext contextOrder = new DataContext();
        // GET: Order
        public ActionResult Index()
        {
            var listOrder = contextOrder.Orders.ToList();
            return View(listOrder);
        }

    }
}