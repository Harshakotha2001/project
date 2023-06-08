using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface ICar
    {
        Task<List<Car>> GetAllCar();
        Task<Car> GetCar(int id);
         Task<bool> AddCar(Car car);
         Task<bool> UpdateCar(Car car);
         Task<bool> DeleteCar(int id);
    }
}
