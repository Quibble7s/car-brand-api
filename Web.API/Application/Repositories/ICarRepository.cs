using Web.API.Application.DTOs;

namespace Web.API.Application.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<CarBrandDTO>> GetBrandsAsync();
    }
}
