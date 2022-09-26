using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;

namespace mvc_app.Models
{
    public class ApplicationContext : DbContext
    {
        // настройка таблиц базы данных
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Data101> data101 {get; set;}
        public DbSet<Data201> data201 {get; set;}
        public DbSet<Data401> data401 {get; set;}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // заполняем бд при первом обращении
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminNumber = "u55220";
            string adminPassword = "123456";

            // добавляем роли
            Role adminRole = new Role { Id = 1, Name = adminRoleName };
            Role userRole = new Role { Id = 2, Name = userRoleName };

            // добавляем отделы
            Department dep1 = new Department { Id = 1, Name = "первый" };
            Department dep2 = new Department { Id = 2, Name = "второй" };
            Department dep3 = new Department { Id = 3, Name = "третий" };
            // добавляем цеха
            //Shop shop1 = new Shop { Id = 1, Number = "101", DepartmentId = 1 };
            //Shop shop2 = new Shop { Id = 2, Number = "201", DepartmentId = 2 };
            //Shop shop3 = new Shop { Id = 3, Number = "301", DepartmentId = 3 };

            List<Shop> shops = new List<Shop> {
                new Shop {Id = 1, Number = "101", DepartmentId = 1 },
                new Shop {Id = 2, Number = "102", DepartmentId = 1 },
                new Shop {Id = 3, Number = "104", DepartmentId = 1 },
                new Shop {Id = 4, Number = "105", DepartmentId = 1 },
                new Shop {Id = 5, Number = "106-1", DepartmentId = 1 },
                new Shop {Id = 6, Number = "106-2", DepartmentId = 1 },
                new Shop {Id = 7, Number = "201", DepartmentId = 2 },
                new Shop {Id = 8, Number = "204", DepartmentId = 2 },
                new Shop {Id = 9, Number = "401", DepartmentId = 3 },
                new Shop {Id = 10, Number = "402", DepartmentId = 3 },
            };

            // добавляем пользователей
            User adminUser = new User { Id = 1, Number = adminNumber, Password = adminPassword, RoleId = adminRole.Id, ShopId = 1 };
            User user1 = new User { Id = 2, Number = "u11111", Password = "111", RoleId = userRole.Id, ShopId = 1 };
            User user2 = new User { Id = 3, Number = "u22222", Password = "222", RoleId = userRole.Id, ShopId = 7 };
            User user3 = new User { Id = 4, Number = "u33333", Password = "333", RoleId = userRole.Id, ShopId = 9 };

            // добавляем всё в бд
            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Department>().HasData(new Department[] { dep1, dep2, dep3 });
            modelBuilder.Entity<Shop>().HasData(shops);
            modelBuilder.Entity<User>().HasData(new User[] { adminUser, user1, user2, user3 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
