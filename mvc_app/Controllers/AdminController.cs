using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mvc_app.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace mvc_app.Controllers
{
    [Authorize(Roles ="admin")]
    public class AdminController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public AdminController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }
        public async Task<IActionResult> UserList()
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.UserList method called\n User: {0}", CurrentUser);
            
            ViewBag.Roles = await db.Roles.ToListAsync();
            ViewBag.Shops = await db.Shops.ToListAsync();
            ViewBag.Role = "admin";
            return View(await db.Users.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Create method called\n User: {0}", CurrentUser);
            
            var shops = await db.Shops.ToListAsync();
            ViewBag.Shops = new SelectList(shops, "Id", "Number");

            var roles = await db.Roles.ToListAsync();
            ViewBag.Roles = new SelectList(roles, "Id", "Name");
            ViewBag.Role = "admin";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Create method called\nUser: {0}", CurrentUser);
            _logger.LogInformation("Adding new user: {0} {1} {2}", user.Number, user.Id, user.RoleId);
            
            db.Users.Add(user);
            await db.SaveChangesAsync();
            
            _logger.LogInformation("Created new user {0} with role {1}", user.Number, user.RoleId);
            return RedirectToAction("UserList");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Edit method called\nUser: {0}", CurrentUser);
            
            if (id != null)
            {
                var shops = await db.Shops.ToListAsync();
                ViewBag.Shops = new SelectList(shops, "Id", "Number");
                var roles = await db.Roles.ToListAsync();
                ViewBag.Roles = new SelectList(roles, "Id", "Name");
                ViewBag.Role = "admin";
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(User user)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Edit method called\nUser: {0}", CurrentUser);
            
            db.Users.Update(user);
            await db.SaveChangesAsync();
            
            _logger.LogInformation("Edited user {0} with id {1}", user.Number, user.Id);
            return RedirectToAction("UserList");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.ConfirmDelete method called\nUser: {0}", CurrentUser);
            if (id != null)
            {
                User user = await db.Users.FirstOrDefaultAsync(p => p.Id == id);
                if (user != null)
                    return View(user);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Delete method called\nUser: {0}", CurrentUser);
            if (id != null)
            {
                User user = new User { Id = id.Value };
                db.Entry(user).State = EntityState.Deleted;
                await db.SaveChangesAsync();
                
                _logger.LogInformation("Deleted user with id {0}", id);
                return RedirectToAction("UserList");   
            }
            return NotFound();
        }

        public IActionResult CreateRole(){
            ViewBag.Role = "admin";
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(Role role){
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Create method called\nUser: {0}", CurrentUser);
            _logger.LogInformation("Adding new role: {0} {1}", role.Id, role.Name);

            db.Roles.Add(role);
            await db.SaveChangesAsync();

            _logger.LogInformation("Created new role {0} with Id {1}", role.Name, role.Id);
            return RedirectToAction("RoleList");
        }

        public async Task<IActionResult> RoleList()
        {
            ViewBag.Role = "admin";
            return View(await db.Roles.ToListAsync());
        }

        public async Task<IActionResult> Department()
        {
            return View(await db.Departments.ToListAsync());
        }
    }
}
