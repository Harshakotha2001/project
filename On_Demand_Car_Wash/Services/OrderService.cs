using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Services
{
    public class OrderService
    {
        private IOrder _IOrder;
        public OrderService(IOrder Iorder)
        {
            _IOrder = Iorder;
        }
        public async Task<List<Order>> GetAllOrder()
        {
            return await _IOrder.GetAllOrder();
        }
        public async Task<Order> GetOrder(int id)
        {
            return await _IOrder.GetOrder(id);
        }
        public async Task<bool> AddOrder(Order order)
        {
            return await _IOrder.AddOrder(order);
        }
        public async Task<bool> UpdateOrder(Order order)
        {
            return await _IOrder.UpdateOrder(order);
        }
        public async Task<bool> DeleteOrder(int id)
        {
            return await _IOrder.DeleteOrder(id);
        }
    }
}
