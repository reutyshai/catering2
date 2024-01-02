using catering.Core.Entitys;
using Microsoft.EntityFrameworkCore;

namespace catering.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Dish> Dishes { get; set; }

        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }

    }
}
