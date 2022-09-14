using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_app.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace mvc_app.Controllers
{
    [Authorize]

    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        //[AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await db.Users.ToListAsync());
        }

        
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                ViewBag.Name = user.Number;
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }
    }
}
