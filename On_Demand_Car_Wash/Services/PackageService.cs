using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Services
{
    public class PackageService
    {
        private IPackage _IPackage;
        public PackageService(IPackage Ipackage)
        {
            _IPackage = Ipackage;
        }
        public async Task<List<Package>> GetAllPackage()
        {
            return await _IPackage.GetAllPackage();
        }
        public async Task<Package> GetPackage(int id)
        {
            return await _IPackage.GetPackage(id);
        }
        public async Task<bool> AddPackage(Package package)
        {
            return await _IPackage.AddPackage(package);
        }
        public async Task<bool> UpdatePackage( Package package)
        {
            return await _IPackage.UpdatePackage(package);
        }
        public async Task<bool> DeletePackage(int id)
        {
            return await _IPackage.DeletePackage(id);
        }
    }
}
