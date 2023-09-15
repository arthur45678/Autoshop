

using Autoshop.Domain.Entity;
using Autoshop.Domain.Response;
using Autoshop.Domain.ViewModels.Car;
// todo
namespace Autoshop.Service.Interfaces;

public interface ICarService
{
    Task<IBaseResponse<IEnumerable<Car>>> GetCars();
        
    Task<IBaseResponse<CarViewModel>> GetCar(int id);

    Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);

    Task<IBaseResponse<bool>> DeleteCar(int id);

    Task<IBaseResponse<Car>> GetCarByName(string name);

    Task<IBaseResponse<Car>> Edit(int id, CarViewModel model);
}