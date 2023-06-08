﻿using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.Context;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Repository
{
    public class AddressRepository : IAddress
    {
        private CarDbContext _addressDb;
        public AddressRepository(CarDbContext addressDbContext)
        {
            _addressDb = addressDbContext;
        }

        #region Get Address
        public async Task<bool> AddAddress(Address add)
        {
            try
            {
                if (add == null)
                {
                    return false;
                }
                await _addressDb.Addresses.AddAsync(add);
               await _addressDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion Adding Address

        #region Delete Address
        public async Task<bool> DeleteAddress(int id)
        {
            try
            {
                var add = await _addressDb.Addresses.FindAsync(id);
                if (add == null)
                    return false;
                 _addressDb.Addresses.Remove(add);
                await _addressDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion Delete Address

        #region GetAll Address
        public async Task<List<Address>> GetAllAddress()
        {
            try
            {
                var temp = await _addressDb.Addresses.ToListAsync();
                return temp;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion GetAll Address

        #region Get Address
        public async Task<Address> GetAddress(int id)
        {
            Address add;
            try
            {
                add = await _addressDb.Addresses.FindAsync(id);
                if (add != null)
                {
                    return add;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return add;
        }
        #endregion Get Address

        #region Update Address
        public async Task<bool> UpdateAddress(Address add)
        {
            try
            {
                var address = await _addressDb.Addresses.AsNoTracking().FirstOrDefaultAsync(u => u.Id == add.Id);
                if (address != null)
                    return false;
                 _addressDb.Addresses.Update(add);
                await _addressDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion Update Address


    }
}
