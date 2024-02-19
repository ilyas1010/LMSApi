using Microsoft.AspNetCore.Mvc;
using LMSApi.AppDbContext;
using Microsoft.EntityFrameworkCore;
using LMSApi.Models;
using System;

namespace LMSApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VacutainerController : ControllerBase
    {
       private readonly LMSDbContext DbContext;
        public VacutainerController(LMSDbContext dbContext)
        {
            this.DbContext = dbContext;   
        }
        [HttpPost]
     
        public async Task<IActionResult> CreateVacutainer(Vacutainer patient)
        {
            try
            {
                await DbContext.Vacutainers.AddAsync(patient);
                DbContext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpGet]
        public async Task<List<Vacutainer>> GetVacutainers()
        {
            List<Vacutainer> lstVacutainer = await DbContext.Vacutainers.ToListAsync();
            return lstVacutainer;
        }

    }
}
