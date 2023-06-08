﻿using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.Models;
using On_Demand_Car_Wash.Services;

namespace On_Demand_Car_Wash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private PackageService packageService;
        public PackageController(PackageService _packageService)
        {
            packageService = _packageService;
        }
       // [Authorize(Roles = "Admin")]
        [HttpGet("GetAllPackage")]
        public async Task<ActionResult<List<Package>>> GetAllPackage()
        {
            var temp = await packageService.GetAllPackage();
            return  Ok(temp);
        }
        [HttpGet("GetPackage")]
        public async Task<ActionResult<Package>> GetPackage(int id)
        {
            return Ok(await packageService.GetPackage(id));
        }
       // [Authorize(Roles = "Admin")]
        [HttpPost("AddPackage")]
        public async Task<ActionResult<bool>> AddPackage(Package package)
        {
            return Ok(await packageService.AddPackage(package));
        }
       // [Authorize(Roles = "Admin")]
        [HttpPut("UpdatePackage")]
        public async Task<ActionResult<bool>> UpdatePackage(Package package)
        {
            return Ok(await packageService.UpdatePackage(package));
        }
       // [Authorize(Roles = "Admin")]
        [HttpDelete("DeletePackage/{id}")]
        public async Task<ActionResult<bool>> DeletePackage([FromRoute]int id)
        {
            return Ok(await packageService.DeletePackage(id));
        }
    }
}
