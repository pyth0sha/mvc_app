using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using mvc_app.Data;
using System;
using System.Linq;

namespace mvc_app.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationContext>>()))
            {
                if (context.Shops.Any())
                {
                    return;
                }

                context.Shops.AddRange(
                    new Shop
                    {
                        Number = "101",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "102",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "104",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "105",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "106-1",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "106-2",
                        DepartmentId = 1
                    },
                    new Shop
                    {
                        Number = "201",
                        DepartmentId = 2
                    },
                    new Shop
                    {
                        Number = "204",
                        DepartmentId = 2
                    },
                    new Shop
                    {
                        Number = "401",
                        DepartmentId = 3
                    },
                    new Shop
                    {
                        Number = "402",
                        DepartmentId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
