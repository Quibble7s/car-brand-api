using Application.DTOs;

namespace Application.Repositories
{
    public class CarRepository : ICarRepository
    {
        public CarRepository()
        {

        }

        public async Task<IEnumerable<CarBrandDTO>> GetBrandsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
