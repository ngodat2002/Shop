using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2010A_WAD.Models;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;

namespace T2010A_WAD.Controllers
{
    public class AuthUserController : Controller
    {
        private DataContext db = new DataContext();
        // GET: AuthUser
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Models.User user)
        {
            if (ModelState.IsValid)
            {
                var check = db.Users.FirstOrDefault(s => s.Username.Equals(user.Username));
                if (check == null)
                {
                    user.Password = GetMD5(user.Password);
                    db.Users.Add(user);
                    db.SaveChanges();
                    FormsAuthentication.SetAuthCookie(user.Username, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "User đã tồn tại!";
                }
            }
            return View();
        }
        private string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] frData = Encoding.UTF8.GetBytes(str);
            byte[] toData = md5.ComputeHash(frData);
            string hashString = "";
            foreach (var i in toData)
            {
                hashString += i.ToString("x2");
            }
            return hashString;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.User user)
        {
            if (ModelState.IsValid)
            {
                user.Password = GetMD5(user.Password);
                var data = db.Users.Where(s => s.Username.Equals(user.Username)&& s.Password.Equals(user.Password)).FirstOrDefault();
                if (data != null)
                {
                    FormsAuthentication.SetAuthCookie(data.Username, true);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}