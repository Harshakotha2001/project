
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Services
{
    public class UserDetailService
    {
        public readonly IUserDetail inter;
        public UserDetailService(IUserDetail repository)
        {
            inter = repository; 
        }

        public async Task<CustomReturnType> Login(UserDetail user)
        {
            return await inter.Login(user);
        }

        public async Task<CustomReturnType> Register(UserDetail user)
        {
            return await inter.Register(user);
        }

        public async Task<List<UserDetail>>  GetUserDetails()
        {
            return await inter.GetUserDetails();
        }

        public async Task<bool> DeleteUserDetails(int id)
        {
            return await inter.DeleteUserDetails(id);
        }

    }
}
