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
    //[Authorize]

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
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == user.RoleId);
            ViewBag.Role = role.Name;
            //return View(await db.Users.ToListAsync());

            return View(await db.Departments.ToListAsync());
        }

        public async Task<IActionResult> Department(int? id)
        {
            return View(await db.Departments.ToListAsync());
        }
        
    }
}
