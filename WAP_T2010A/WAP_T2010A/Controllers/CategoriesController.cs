using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAP_T2010A.Models;

namespace WAP_T2010A.Controllers
{
    public class CategoriesController : Controller
    {
        private DataContext contextCategories = new DataContext();
        // GET: Categories
        public ActionResult Index()
        {
            var listCategories = contextCategories.Categories.ToList();

            return View(listCategories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                //khi du lieu gui len thoa ma yeu cau(yeu cau theo Model)-> luu vao DB
                contextCategories.Categories.Add(category);
                contextCategories.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);//tro lai giao dien kem du lieu vua nhap
        }
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = contextCategories.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();            
            }
            return View(category);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Category category)
        {
            if (ModelState.IsValid)
            {
                contextCategories.Entry(category).State = System.Data.Entity.EntityState.Modified;
                contextCategories.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Category category = contextCategories.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            contextCategories.Categories.Remove(category);
            contextCategories.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}