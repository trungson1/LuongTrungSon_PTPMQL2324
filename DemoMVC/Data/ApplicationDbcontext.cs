using DemoMVC.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Person> Person {get; set; }
        public DbSet<DemoMVC.Models.Hethongphanphoi> Hethongphanphoi { get; set; } = default!;
    }

}
