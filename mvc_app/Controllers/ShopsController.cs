using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc_app.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using SmartBreadcrumbs.Attributes;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace mvc_app.Controllers
{
    [Authorize]
    public class ShopsController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public ShopsController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }
        /// <summary>
        /// Перенаправляет на нужную форму в зависимости от цеха
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dataEntered"></param>
        /// <returns></returns>

        [Route("Shops/Edit")]
        [Breadcrumb("Цех", FromAction="Index", FromController=typeof(HomeController))]
        public async Task<IActionResult> Index(int? id)
        {   
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == user.RoleId);
            ViewBag.Role = role.Name;
            if (id != null)
            {
                int Id = id.GetValueOrDefault();
                var shopActions = new List<string> {"Shop101", "Shop102","Shop104","Shop105","Shop106_1","Shop106_2","Shop201","Shop204","Shop401","Shop402"};
                return View(shopActions[Id-1]);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop101(Data101 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 1;
            data.Calculate();
            db.data101.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=1});
        }

        [HttpPost]
        public async Task<IActionResult> Shop102(Data102 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 2;
            data.Calculate();
            db.data102.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=2});
        }

        [HttpPost]
        public async Task<IActionResult> Shop104(Data104 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 3;
            data.Calculate();
            db.data104.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=3});
        }

        [HttpPost]
        public async Task<IActionResult> Shop105(Data105 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 4;
            data.Calculate();
            db.data105.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=4});
        }

        [HttpPost]
        public async Task<IActionResult> Shop106_1(Data106_1 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 5;
            data.Calculate();
            db.data106_1.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=5});
        }

        [HttpPost]
        public async Task<IActionResult> Shop106_2(Data106_2 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 6;
            data.Calculate();
            db.data106_2.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=6});
        }

        [HttpPost]
        public async Task<IActionResult> Shop201(Data201 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            // data.ShopId = 7;
            // data.Calculate();
            // db.data201.Add(data);
            // await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=7});
        }

        [HttpPost]
        public async Task<IActionResult> Shop204(Data204 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 8;
            data.Calculate();
            db.data204.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=8});
        }

        [HttpPost]
        public async Task<IActionResult> Shop401(Data401 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 9;
            data.Calculate();
            db.data401.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=9});
        }

        [HttpPost]
        public async Task<IActionResult> Shop402(Data402 data)
        {
            // User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = 10;
            data.Calculate();
            db.data402.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=10});
        }

        public async Task<IActionResult> ShopHistory(int? id, int? pageNumber)
        {
            var data = from s in db.data101 select s;
            int pageSize = 1;
            return View(await PaginatedList<Data101>.CreateAsync(data, pageNumber ?? 1, pageSize));
        }

        public ViewResult Test()
        {
            Data102 data = new Data102{};
            return View(data);
        }
    }
}
