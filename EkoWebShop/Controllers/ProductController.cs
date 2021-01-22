using EkoWebShop.Data;
using EkoWebShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EkoWebShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ProductController(ApplicationDbContext db)
        {
            _db = db;     
        }
        
        // GET: ProductController
        public ActionResult Index()
        {
            IEnumerable<Product> objList = _db.Products;
            return View(objList);
            
        }


        // GET for create
        public ActionResult Create()
        {
            return View();
        }
        //post for create
        [HttpPost] // this tells the program that this will post to db
        [ValidateAntiForgeryToken] // Protects from some kinda attack
        //something to do when we click create and action "submit/post" gets called
        public IActionResult Create(Product obj)
        {

            _db.Products.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");


        }
        
        


       
        // GET: ProductController/Edit/3
        public ActionResult Edit(int? id)
        {
            var productfromDb = _db.Products.Find(id);

            return View(productfromDb);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _db.Products.Update(product);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
               return NotFound();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
