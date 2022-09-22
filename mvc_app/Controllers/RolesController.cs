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
        public async Task<IActionResult> Index()
        {
            ViewBag.Role = "admin";
            return View(await db.Roles.ToListAsync());
        }
    }
}
