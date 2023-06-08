using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IPackage
    {
        Task<List<Package>> GetAllPackage();
        Task<Package> GetPackage(int id);
         Task<bool> AddPackage(Package package);
         Task<bool> UpdatePackage(Package package);
         Task<bool> DeletePackage(int id);
    }
}
