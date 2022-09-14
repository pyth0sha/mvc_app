using Microsoft.EntityFrameworkCore;

namespace mvc_app.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
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
            // добавляем админа
            User adminUser = new User { Id = 1, Number = adminNumber, Password = adminPassword, RoleId = adminRole.Id };
            // добавляем отделы
            Department dep1 = new Department { Id = 1, Name = "первый" };
            Department dep2 = new Department { Id = 2, Name = "второй" };
            Department dep3 = new Department { Id = 3, Name = "третий" };

            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            modelBuilder.Entity<Department>().HasData(new Department[] { dep1, dep2, dep3 });

            base.OnModelCreating(modelBuilder);
        }
    }
}
