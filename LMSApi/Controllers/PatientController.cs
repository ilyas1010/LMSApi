using Microsoft.AspNetCore.Mvc;
using LMSApi.AppDbContext;
using Microsoft.EntityFrameworkCore;
using LMSApi.Models;
using System;

namespace LMSApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
       private readonly LMSDbContext DbContext;
        public PatientController(LMSDbContext dbContext)
        {
            this.DbContext = dbContext;   
        }
        [HttpPost]
       // [Route("CreatePatient")]
        public async Task<IActionResult> CreatePatient(Patient patient)
        {
            try
            {
                await DbContext.Patients.AddAsync(patient);
                DbContext.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);

            }
        }
        [HttpGet]
        //[Route("GetPatients")]
        public async Task<List<Patient>> GetPatients()
        {
          List<Patient> lstPatient =await DbContext.Patients.ToListAsync();
            return lstPatient;
        }

    }
}
