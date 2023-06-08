﻿using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.IRepository
{
    public interface IUserDetail
    {
        Task<CustomReturnType> Login(UserDetail user);
        Task<CustomReturnType> Register(UserDetail user);
        Task<List<UserDetail>> GetUserDetails();

        Task<bool> DeleteUserDetails(int id);

    }
}
