using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IOrderSendingData
    {
         Task<List<OrderSendingData>> GetAllDetails();
    }
}
