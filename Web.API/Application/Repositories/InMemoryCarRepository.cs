using Web.API.Application.DTOs;
using Web.API.Models.Context;

namespace Web.API.Application.Repositories
{
    public class InMemoryCarRepository : ICarRepository
    {
        private readonly InMemoryDbContext _context;

        public InMemoryCarRepository(InMemoryDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarBrandDTO>> GetBrandsAsync()
        {
            return await Task.FromResult(_context.CarBrands.Select(brand => new CarBrandDTO { Id = brand.Id, Name = brand.Name }));
        }
    }
}
