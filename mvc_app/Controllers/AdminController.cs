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
            return View(await db.Users.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Create method called\n User: {0}", CurrentUser);
            var shops = await db.Shops.ToListAsync();
            ViewBag.Shops = new SelectList(shops, "Id", "Number");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var CurrentUser = User.Identity.Name;
            _logger.LogInformation("Admin.Create method called\nUser: {0}", CurrentUser);
            // new user Id starts from 1007 now, but why???
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
                // output: Deleted user <null>, look at ConfirmDelete method 87
                _logger.LogInformation("Deleted user {0} with id {1}", user.Number, id);
                return RedirectToAction("UserList");   
            }
            return NotFound();
        }

        public async Task<IActionResult> Department()
        {
            return View(await db.Departments.ToListAsync());
        }
    }
}
