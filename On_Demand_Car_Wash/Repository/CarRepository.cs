﻿using Microsoft.EntityFrameworkCore;
using On_Demand_Car_Wash.Context;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Models;

namespace On_Demand_Car_Wash.Repository
{
    public class CarRepository:ICar
    {
        private CarDbContext _carDb;
        public CarRepository(CarDbContext carDbContext)
        {
            _carDb = carDbContext;
        }

        #region Get Car  
        public async Task<bool> AddCar(Car car)
        {
            try
            {
                if (car == null)
                {
                    return false;
                }
                await _carDb.Cars.AddAsync(car);
                await _carDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion Adding Car

        #region Delete Car
        public async Task<bool> DeleteCar(int id)
        {
            try
            {
                var car = await _carDb.Cars.FindAsync(id);
                if (car == null)
                    return false;
                _carDb.Cars.Remove(car);
                await _carDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion Delete Car

        #region GetAll Car
        public async Task<List<Car>> GetAllCar()
        {
            try
            {
                var car = await _carDb.Cars.ToListAsync();
                return car;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion GetAll Car

        #region Get Car
        public async Task<Car> GetCar(int id)
        {
            Car car;
            try
            {
                car = await _carDb.Cars.FindAsync(id);
                if (car != null)
                {
                    return car;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return car;
        }
        #endregion Get Car

        #region Update Car
        public async Task<bool> UpdateCar(Car add)
        {
            try
            {
                var car = await _carDb.Cars.AsNoTracking().FirstOrDefaultAsync(u => u.Id == add.Id);
                if (car != null)
                    return false;
                _carDb.Cars.Update(add);
                await _carDb.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion Update Car
    }
}
