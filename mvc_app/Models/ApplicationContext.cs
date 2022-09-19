using Microsoft.EntityFrameworkCore;

namespace mvc_app.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();   // создаем базу данных при первом обращении
            //Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
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
            Shop shop1 = new Shop { Id = 1, Number = "101", DepartmentId = 1 };
            Shop shop2 = new Shop { Id = 2, Number = "201", DepartmentId = 2 };
            Shop shop3 = new Shop { Id = 3, Number = "301", DepartmentId = 3 };

            // добавляем пользователей
            User adminUser = new User { Id = 1, Number = adminNumber, Password = adminPassword, RoleId = adminRole.Id, ShopId = shop1.Id };
            User customUser = new User { Id = 2, Number = "u12345", Password = "123", RoleId = userRole.Id, ShopId = shop2.Id };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<Department>().HasData(new Department[] { dep1, dep2, dep3 });
            modelBuilder.Entity<Shop>().HasData(new Shop[] { shop1, shop2, shop3 });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser, customUser });

            base.OnModelCreating(modelBuilder);
        }
    }
}
