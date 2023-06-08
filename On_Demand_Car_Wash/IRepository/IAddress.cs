using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IAddress
    {
        Task<List<Address>> GetAllAddress();
        Task<Address> GetAddress(int id);
        Task<bool> AddAddress(Address address);
        Task<bool> UpdateAddress(Address address);
        Task<bool> DeleteAddress(int id);
    }
}
