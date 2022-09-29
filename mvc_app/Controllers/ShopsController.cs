using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc_app.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartBreadcrumbs.Attributes;

namespace mvc_app.Controllers
{
    [Breadcrumb("Цех")]
    public class ShopsController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public ShopsController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }
        
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                int Id = id.GetValueOrDefault();
                var shopActions = new List<string> {"Shop101", "Shop102","Shop104","Shop105","Shop106_1","Shop106_2","Shop201","Shop204","Shop401","Shop402"};
                return RedirectToAction(shopActions[Id-1]);
            }
            return View();
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop101()
        {
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
        [Breadcrumb("Цех")]
        public IActionResult Shop102()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop102(Data102 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data102.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop102");
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop104()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop104(Data104 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data104.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop104");
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop105()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop105(Data105 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data105.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop105");
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop106_1()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop106_1(Data106_1 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data106_1.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop106_1");
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop106_2()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop106_2(Data106_2 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data106_2.Add(data);
            await db.SaveChangesAsync();
            return RedirectToAction("Shop106_1");
        }

        [HttpGet]
        [Breadcrumb("Цех")]
        public IActionResult Shop201()
        {
            return View();
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
        [Breadcrumb("Цех")]
        public IActionResult Shop401()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Shop401(Data401 data)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            data.ShopId = user.ShopId;
            db.data401.Add(data);
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
