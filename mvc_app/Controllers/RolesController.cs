using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using SmartBreadcrumbs.Attributes;

namespace mvc_app.Controllers
{
    [Authorize(Roles = "admin")]
    
    public class RolesController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public RolesController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }

        [Breadcrumb("Роли", FromAction="Index", FromController=typeof(HomeController))]
        public async Task<IActionResult> Index()
        {
            ViewBag.Role = "admin";
            return View(await db.Roles.ToListAsync());
        }

        [Breadcrumb("Добавить", FromAction="Index")]
        public IActionResult Create()
        {
            ViewBag.Role = "admin";
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Create(Role role)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Roles.Create method called\nUser: {0}", CurrentUser);
            _logger.LogInformation("Adding new role: {0} {1}", role.Id, role.Name);

            db.Roles.Add(role);
            await db.SaveChangesAsync();

            _logger.LogInformation("Created new role {0} with Id {1}", role.Name, role.Id);
            return RedirectToAction("Index", "Roles");
        }

        [HttpGet]
        [ActionName("Delete")]
        [Breadcrumb("Удалить", FromAction="Index")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            ViewBag.Role = "admin";
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Roles.ConfirmDelete method called\nUser: {0}", CurrentUser);
            if (id != null)
            {
                Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == id);
                if (role != null)
                    return View(role);
            }
            return NotFound();
        }

        [HttpPost]

        public async Task<IActionResult> Delete(int? id)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Roles.Delete method called\nUser: {0}", CurrentUser);
            if (id != null)
            {
                Role role = new Role { Id = id.Value };
                db.Entry(role).State = EntityState.Deleted;
                await db.SaveChangesAsync();

                _logger.LogInformation("Deleted role with id {0}", id);
                return RedirectToAction("Index", "Roles");
            }
            return NotFound();
        }
    }
}
