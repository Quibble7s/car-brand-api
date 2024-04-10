using Microsoft.EntityFrameworkCore;
using Web.API.Application.DTOs;
using Web.API.Models.Context;

namespace Web.API.Application.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly APIDbContext _context;

        public CarRepository(APIDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarBrandDTO>> GetBrandsAsync()
        {
            return await _context.CarBrands.AsNoTracking().Select(brand => new CarBrandDTO { Id = brand.Id, Name = brand.Name}).ToListAsync();
        }
    }
}
