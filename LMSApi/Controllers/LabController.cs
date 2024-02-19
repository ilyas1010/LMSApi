using Microsoft.AspNetCore.Mvc;
using LMSApi.AppDbContext;
using Microsoft.EntityFrameworkCore;
using LMSApi.Models;
using System;

namespace LMSApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LabController : ControllerBase
    {
       private readonly LMSDbContext DbContext;
        public LabController(LMSDbContext dbContext)
        {
            this.DbContext = dbContext;   
        }
        [HttpPost]
       // [Route("CreateLab")]
        public async Task<IActionResult> CreateLab(Lab patient)
        {
            try
            {
                await DbContext.Labs.AddAsync(patient);
                DbContext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpGet]
        //[Route("GetLabs")]
        public async Task<List<Lab>> GetLabs()
        {
          List<Lab> lstLab =await DbContext.Labs.ToListAsync();
            return lstLab;
        }

    }
}
