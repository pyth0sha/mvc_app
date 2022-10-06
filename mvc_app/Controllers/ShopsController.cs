using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using mvc_app.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartBreadcrumbs.Attributes;
using System;
using SmartBreadcrumbs.Nodes;

namespace mvc_app.Controllers
{
    //[Breadcrumb("Отдел")]
    public class ShopsController : Controller
    {
        private ApplicationContext db;
        private readonly ILogger _logger;

        public ShopsController(ApplicationContext context, ILogger<AdminController> logger)
        {
            db = context;
            _logger = logger;
        }

        [Route("Shops/Edit")]
        [Breadcrumb("Цех", FromAction="Index", FromController=typeof(HomeController))]
        public async Task<IActionResult> Index(int? id, bool? dataEntered)
        {   
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            Role role = await db.Roles.FirstOrDefaultAsync(p => p.Id == user.RoleId);
            ViewBag.Role = role.Name;
            if (id != null)
            {
                int Id = id.GetValueOrDefault();
                var shopActions = new List<string> {"Shop101", "Shop102","Shop104","Shop105","Shop106_1","Shop106_2","Shop201","Shop204","Shop401","Shop402"};
                
                //return RedirectToAction(shopActions[Id-1]);
                // if(dataEntered == true)
                // {
                //     switch(id)
                //     {
                //         case 1:
                //     }
                // }
                return View(shopActions[Id-1]);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Proceed(Data101 data101,
                                            Data102 data102,
                                            Data104 data104,
                                            Data105 data105,
                                            Data106_1 data106_1,
                                            Data106_2 data106_2,
                                            Data201 data201,
                                            Data204 data204,
                                            Data401 data401,
                                            Data402 data402)
        {
            User user = await db.Users.FirstOrDefaultAsync(p => p.Number == User.Identity.Name);
            var shopId = user.ShopId;
            if(data101 != null){
                data101.ShopId = user.ShopId;
                data101.Calculate();
                db.data101.Add(data101);
            }
            else if(data102 != null){
                data102.ShopId = user.ShopId;
                data102.Calculate();
                db.data102.Add(data102);
            }
            else if(data104 != null){
                data104.ShopId = user.ShopId;
                data104.Calculate();
                db.data104.Add(data104);
            }
            else if(data105 != null){
                data105.ShopId = user.ShopId;
                data105.Calculate();
                db.data105.Add(data105);
            }
            else if(data106_1 != null){
                data106_1.ShopId = user.ShopId;
                data106_1.Calculate();
                db.data106_1.Add(data106_1);
            }
            else if(data106_2 != null){
                data106_2.ShopId = user.ShopId;
                data106_2.Calculate();
                db.data106_2.Add(data106_2);
            }
            else if(data201 != null){
                data201.ShopId = user.ShopId;
                //data201.Calculate();
                db.data201.Add(data201);
            }
            else if(data204 != null){
                data204.ShopId = user.ShopId;
                data204.Calculate();
                db.data204.Add(data204);
            }
            else if(data401 != null){
                data401.ShopId = user.ShopId;
                data401.Calculate();
                db.data401.Add(data401);
            }
            else if(data402 != null){
                data402.ShopId = user.ShopId;
                data402.Calculate();
                db.data402.Add(data402);
            }
            
            await db.SaveChangesAsync();
            return RedirectToAction("Index", new {id=shopId, dataEntered=true});
        }
    }
}
