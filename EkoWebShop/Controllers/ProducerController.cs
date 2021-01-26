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
    
    public class ProducerController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ProducerController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        
        // GET: ProducerController
        public ActionResult Index()
        {
            IEnumerable<Producer> objList = _db.Producers;
            return View(objList);
            
        }

        // GET: ProducerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProducerController/Create - page we GET to create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducerController/Create - Post the create to DB
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producer obj)
        {
            if (ModelState.IsValid) // This here is the DB side validation, together with the thingis added in the model class: required, range etc.
            {
                _db.Producers.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }

        }

        // GET: ProducerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProducerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ProducerController/Delete/5
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            else
            {
                var ProducerFromDb = _db.Producers.Find(id); // this works! It goes looking for the primary key! 

                if (ProducerFromDb == null)
                    return NotFound();
                else
                {

                    _db.Producers.Remove(ProducerFromDb);
                    _db.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

        }
    }
}
