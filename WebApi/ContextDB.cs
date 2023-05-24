using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class ContextDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=videoLibrary;Username=postgres;Password=5689");
        }

        public ContextDB()
        {
            Database.EnsureCreated();
        }


        public DbSet<Delivery> delivery { get; set; }
        public DbSet<Sale> sale { get; set; }
        public DbSet<Customer> customer { get; set; }
        public DbSet<Employee> employee { get; set; }
        public DbSet<Cassette> cassette { get; set; }
        public DbSet<Genre> genre { get; set; }
        public DbSet<Director> director { get; set; }
        public DbSet<Country> country { get; set; }


    }

}
