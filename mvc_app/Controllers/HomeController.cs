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
using SmartBreadcrumbs.Attributes;
using mvc_app.ViewModels;

namespace mvc_app.Controllers
{
    [DefaultBreadcrumb("Главная")]
    public class HomeController : Controller
    {
        List<Department> deps;
        List<Shop> shops;
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        /// <summary>
        /// Главная страница приложения, отображает список цехов
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Index()
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            if (user != null)
            {
                Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == user.RoleId);
                ViewBag.Role = role.Name;
            }

            deps = await db.Departments.ToListAsync();
            shops = await db.Shops.ToListAsync();

            HomeIndexViewModel ivm = new HomeIndexViewModel {Departments = deps, Shops = shops};
            return View(ivm);

            // return View(await db.Departments.ToListAsync());
        }

        // [Breadcrumb("Отдел")]
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

        //public IActionResult ShopDataInput(int? id)
        //{ return View(); }

    }
}
