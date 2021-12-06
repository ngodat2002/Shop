using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAP_T2010A.Models;
namespace WAP_T2010A.Controllers
{
    public class ProductController : Controller
    {
        private DataContext contextProduct = new DataContext();
        // GET: Products
        public ActionResult Index()
        {
            var listProduct = contextProduct.Products.ToList();

            return View(listProduct);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                //khi du lieu gui len thoa ma yeu cau(yeu cau theo Model)-> luu vao DB
                contextProduct.Products.Add(product);
                contextProduct.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);//tro lai giao dien kem du lieu vua nhap
        }
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Product product = contextProduct.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                contextProduct.Entry(product).State = System.Data.Entity.EntityState.Modified;
                contextProduct.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Product product = contextProduct.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            contextProduct.Products.Remove(product);
            contextProduct.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}