using Microsoft.AspNetCore.Mvc;
using Web.API.Application.DTOs;
using Web.API.Application.Repositories;

namespace Web.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet("Brands")]
        public async Task<ActionResult<IEnumerable<CarBrandDTO>>> GetBrandsAsync()
        {
            try
            {
                IEnumerable<CarBrandDTO> carBrands = await _carRepository.GetBrandsAsync();

                if(carBrands == null || carBrands.Count() == 0)
                {
                    return NotFound();
                }

                return Ok(carBrands);
            }
            catch (Exception ex)
            {
                return NotFound(ex.ToString());
            }
        }
    }
}
