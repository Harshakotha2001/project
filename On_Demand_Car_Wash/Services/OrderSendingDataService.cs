using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Services
{
    public class OrderSendingDataService
    {
        private readonly IOrderSendingData repo;

        public OrderSendingDataService(IOrderSendingData _repo)
        {
            repo = _repo;       
        }
        public async Task<List<OrderSendingData>> GetAllDetails()
        {
            return await repo.GetAllDetails();

        }
    }
}
