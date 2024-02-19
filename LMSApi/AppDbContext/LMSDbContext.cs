using LMSApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace LMSApi.AppDbContext
{
    public class LMSDbContext:IdentityDbContext<ApplicationUser>
    {
        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Company> Companies { get; set; }

        public virtual DbSet<CompanyDoctor> CompanyDoctors { get; set; }

        public virtual DbSet<CompanyFranchise> CompanyFranchises { get; set; }

        public virtual DbSet<Investigation> Investigations { get; set; }

        public virtual DbSet<InvestigationReference> InvestigationReferences { get; set; }

        public virtual DbSet<Lab> Labs { get; set; }

        public virtual DbSet<Patient> Patients { get; set; }

        public virtual DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }

        public virtual DbSet<PatientRadHistoTestDetail> PatientRadHistoTestDetails { get; set; }

        public virtual DbSet<PatientRadTest> PatientRadTests { get; set; }

        public virtual DbSet<PatientReferal> PatientReferals { get; set; }

        public virtual DbSet<PatientTest> PatientTests { get; set; }

        public virtual DbSet<PatientTestDetail> PatientTestDetails { get; set; }

     
        public virtual DbSet<ReferalRegion> ReferalRegions { get; set; }

        public virtual DbSet<Test> Tests { get; set; }

        public virtual DbSet<TestAmount> TestAmounts { get; set; }

        public virtual DbSet<TestInvestigation> TestInvestigations { get; set; }

        public virtual DbSet<TestSubType> TestSubTypes { get; set; }

        public virtual DbSet<TestTemplate> TestTemplates { get; set; }

        public virtual DbSet<TestTemplatesDetail> TestTemplatesDetails { get; set; }

        public virtual DbSet<TestTemplatesMaster> TestTemplatesMasters { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<Vacutainer> Vacutainers { get; set; }
    }
}
