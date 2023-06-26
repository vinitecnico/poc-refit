
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using poc_refit.DTO;
using poc_refit.Models;
using poc_refit.Repositories.Interfaces;
using poc_refit.Results;

namespace poc_refit.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class CarController : Controller
    {
        // private readonly ILogger<CarController> _logger;

        // public CarController(ILogger<CarController> logger)
        // {
        //     // _logger = logger;
        // }

        [HttpGet]
        public Task<CarDTO> GetCars([FromServices] ICarRepository repository)
        {
            return repository.ReturnCar();
        }

        [HttpPost]
        public Task<Result> PostCar([FromBody] CarModel car, [FromServices] ICarRepository repository)
        {
            return repository.InsertCar(car);
        }
    }
}