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
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public async Task<IActionResult> Index()
        {
            // главная страница для обычных пользователей
            // содержит список отделов

            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            if (user != null) 
            { 
                Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == user.RoleId);
                ViewBag.Role = role.Name; 
            }

            return View(await db.Departments.ToListAsync());
        }

        public async Task<IActionResult> Department(int? id)
        {
            // страница отдела, содержит список цехов

            if(id != null)
            {
                var shops = from s in db.Shops select s;
                shops = shops.Where(p => p.DepartmentId == id);
                return View(await shops.ToListAsync());
            }
            return NotFound();
        }
        
    }
}
