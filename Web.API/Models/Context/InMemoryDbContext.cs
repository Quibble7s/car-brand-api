using Web.API.Models.ValueObjects;

namespace Web.API.Models.Context
{
    public class InMemoryDbContext
    {
        public List<CarBrand> CarBrands { get; set; }

        public InMemoryDbContext()
        {
            CarBrands = new List<CarBrand>
            {
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
            };
        }
    }
}
