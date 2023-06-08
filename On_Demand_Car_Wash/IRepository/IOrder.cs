using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IOrder
    {
        Task<List<Order>> GetAllOrder();
        Task<Order> GetOrder(int id);
         Task<bool> AddOrder(Order order);
         Task<bool> UpdateOrder(Order order);
         Task<bool> DeleteOrder(int id);
    }
}
