using Autoshop.Domain.Entity;
// todo
namespace Autoshop.DAL.Interfaces;

public interface ICarRepository : IBaseRepository<Car>
{
    Task<Car> GetByName(string name);
}