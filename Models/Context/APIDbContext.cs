using Microsoft.EntityFrameworkCore;
using Models.ValueObjects;

namespace Models.Context
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand
                {
                    Name = "BMW",
                },
                new CarBrand
                {
                    Name = "AUDI",
                },
                new CarBrand
                {
                    Name = "TOYOTA",
                },
                new CarBrand
                {
                    Name = "KIA",
                },
                new CarBrand
                {
                    Name = "SUZUKI",
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        DbSet<CarBrand> CarBrands
        {
            get; set;
        }
    }
}
