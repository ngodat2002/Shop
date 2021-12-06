using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAP_T2010A.Models;

namespace WAP_T2010A.Controllers
{
    public class UserController : Controller
    {
        private DataContext contextUser = new DataContext();
        // GET: User
        public ActionResult Index()
        {
            var listUser = contextUser.Users.ToList();
            return View(listUser);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Update()
        {
            return View();
        }


    }
}