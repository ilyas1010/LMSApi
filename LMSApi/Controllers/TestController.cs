using Microsoft.AspNetCore.Mvc;
using LMSApi.AppDbContext;
using Microsoft.EntityFrameworkCore;
using LMSApi.Models;
using System;

namespace LMSApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
       private readonly LMSDbContext DbContext;
        public TestController(LMSDbContext dbContext)
        {
            this.DbContext = dbContext;   
        }
        [HttpPost]
       // [Route("CreateTest")]
        public async Task<IActionResult> CreateTest(Test patient)
        {
            try
            {
                await DbContext.Tests.AddAsync(patient);
                DbContext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpGet]
        //[Route("GetTests")]
        public async Task<List<Test>> GetTests()
        {
          List<Test> lstTest =await DbContext.Tests.ToListAsync();
            return lstTest;
        }

    }
}
