using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EkoWebShop.Data;
using EkoWebShop.Models;

namespace EkoWebShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }


        //get orders
        public async Task<IActionResult> Index()
        {
            return View(await _db.Products.ToListAsync());
        }


        //Finish order
        public IActionResult Checkout()
        {
            return View();
        }



        
       
        //Shows message after order
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks for your order! You will receive them from 2 to 5 days. You'll get an e-mail with confirmation!";
            return View();
        }
    }
}
