using  System.Threading.Tasks;
using  Refit; // < Referencia ao Refit
using  poc_refit.DTO;
using  poc_refit.Models;
using  poc_refit.Results;

namespace poc_refit.Repositories.Interfaces
{
    public interface ICarRepository
    {
        [Get("/v1/cars")]
		Task<CarDTO> ReturnCar();

		[Post("/v1/cars")]
		Task<Result> InsertCar(CarModel  car);
    }
}