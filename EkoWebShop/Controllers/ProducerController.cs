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

        // GET: ProducerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProducerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProducerController/Delete/5
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
