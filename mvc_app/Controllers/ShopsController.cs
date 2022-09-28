﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc_app.Models;
using System.Linq;
using System.Threading.Tasks;

namespace mvc_app.Controllers
{
    public class ShopsController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public ShopsController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }
        // GET: ShopsController
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                switch (id)
                {
                    case 1:
                        return RedirectToAction("Shop101");
                        
                    case 7:
                        return RedirectToAction("Shop201");
                    case 9:
                        return RedirectToAction("Shop401");

                    default:
                        return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Shop101()
        {
            //User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            //var lastInput = await db.data101.OrderByDescending(p => p.ShopId == user.ShopId).LastOrDefaultAsync();
            //return View(lastInput);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop101(Data101 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data101.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop101");
        }

        [HttpGet]
        public IActionResult Shop201()
        {
            var shop = new Data201 {};
            return View(shop);
        }

        [HttpPost]
        public async Task<IActionResult> Shop201(Data201 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data201.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop201");
        }

        [HttpGet]
        public IActionResult Shop401()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop401(Data101 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data101.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop401");
        }

        // GET: ShopsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShopsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopsController/Create
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

        // GET: ShopsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShopsController/Edit/5
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

        // GET: ShopsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShopsController/Delete/5
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
