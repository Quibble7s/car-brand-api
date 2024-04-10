using Microsoft.AspNetCore.Mvc;
using Web.API.Application.Repositories;
using Web.API.Controllers;
using Web.API.Models.Context;

namespace Tests
{
    public class CarTesting
    {
        private readonly InMemoryDbContext _context;
        private readonly ICarRepository _carRepository;
        private readonly CarsController _controller;

        public CarTesting()
        {
            _context = new InMemoryDbContext();
            _carRepository = new InMemoryCarRepository(_context);
            _controller = new CarsController(_carRepository);
        }

        [Fact]
        public async void GetBrands_OK()
        {
            var result = await _controller.GetBrandsAsync();

            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
