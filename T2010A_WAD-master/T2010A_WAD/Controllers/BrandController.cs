using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2010A_WAD.Models;

namespace T2010A_WAD.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        private DataContext contextBrand = new DataContext();
        public ActionResult Index()
        {
            var listBrand = contextBrand.Brands.ToList();
            return View(listBrand);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                //khi du lieu gui len thoa ma yeu cau(yeu cau theo Model)-> luu vao DB
                contextBrand.Brands.Add(brand);
                contextBrand.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);//tro lai giao dien kem du lieu vua nhap
        }
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Brand brand = contextBrand.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Brand brand)
        {
            if (ModelState.IsValid)
            {
                contextBrand.Entry(brand).State = System.Data.Entity.EntityState.Modified;
                contextBrand.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Brand brand = contextBrand.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            contextBrand.Brands.Remove(brand);
            contextBrand.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}