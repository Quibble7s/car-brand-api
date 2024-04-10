using Microsoft.EntityFrameworkCore;
using Web.API.Models.ValueObjects;

namespace Web.API.Models.Context
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seeds the database with values for the current table "CarBrand".
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand
                {
                    Id = 1,
                    Name = "BMW",
                },
                new CarBrand
                {
                    Id = 2,
                    Name = "AUDI",
                },
                new CarBrand
                {
                    Id = 3,
                    Name = "TOYOTA",
                },
                new CarBrand
                {
                    Id = 4,
                    Name = "KIA",
                },
                new CarBrand
                {
                    Id = 5,
                    Name = "SUZUKI",
                }
            );

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CarBrand> CarBrands
        {
            get; set;
        }
    }
}
