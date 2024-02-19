﻿// <auto-generated />
using System;
using LMSApi.AppDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LMSApi.Migrations
{
    [DbContext(typeof(LMSDbContext))]
    [Migration("20231213183309_vacutainerNewTable")]
    partial class vacutainerNewTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.6.23329.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LMSApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFranchiseUser")
                        .HasColumnType("bit");

                    b.Property<int>("LabId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LMSApi.Models.Company", b =>
                {
                    b.Property<byte>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("CompanyStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FontSize")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FontStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("LMSApi.Models.CompanyDoctor", b =>
                {
                    b.Property<int>("DocId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocId"));

                    b.Property<byte?>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Doctor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Qualification1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualification3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DocId");

                    b.ToTable("CompanyDoctors");
                });

            modelBuilder.Entity("LMSApi.Models.CompanyFranchise", b =>
                {
                    b.Property<int>("FranchiseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FranchiseId"));

                    b.Property<short?>("CompanyId")
                        .HasColumnType("smallint");

                    b.Property<string>("FranchiseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("FranchiseId");

                    b.ToTable("CompanyFranchises");
                });

            modelBuilder.Entity("LMSApi.Models.Investigation", b =>
                {
                    b.Property<int>("InvestigationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvestigationId"));

                    b.Property<string>("BloodQty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestigationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDefault")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSingle")
                        .HasColumnType("bit");

                    b.Property<string>("TerminalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestigationId");

                    b.ToTable("Investigations");
                });

            modelBuilder.Entity("LMSApi.Models.InvestigationReference", b =>
                {
                    b.Property<int>("TempPk")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TempPk"));

                    b.Property<string>("AgeRange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<string>("CriticalValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FExpMax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FExpMin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<string>("MExpMax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MExpMin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TempPk");

                    b.ToTable("InvestigationReferences");
                });

            modelBuilder.Entity("LMSApi.Models.Lab", b =>
                {
                    b.Property<byte>("LabId")
                        .HasColumnType("tinyint");

                    b.Property<string>("LabName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LabId");

                    b.ToTable("Labs");
                });

            modelBuilder.Entity("LMSApi.Models.Patient", b =>
                {
                    b.Property<long>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PatientId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("AgeDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("AmountDue")
                        .HasColumnType("float");

                    b.Property<decimal?>("AmountReceived")
                        .HasColumnType("decimal(18,2)");

                    b.Property<byte?>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("DateTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("FranchiseId")
                        .HasColumnType("tinyint");

                    b.Property<long?>("FranchiseNo")
                        .HasColumnType("bigint");

                    b.Property<int>("MigrationTest")
                        .HasColumnType("int");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nicno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("PatientStatus")
                        .HasColumnType("bit");

                    b.Property<short?>("ReferalId")
                        .HasColumnType("smallint");

                    b.Property<string>("ReferedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("RegisterNo")
                        .HasColumnType("bigint");

                    b.Property<bool?>("SampleDesc")
                        .HasColumnType("bit");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("SexCode")
                        .HasColumnType("tinyint");

                    b.Property<string>("TerminalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("LMSApi.Models.PatientDiagnosis", b =>
                {
                    b.Property<short>("DiagnoseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("DiagnoseId"));

                    b.Property<string>("DiagnoseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiagnoseId");

                    b.ToTable("PatientDiagnoses");
                });

            modelBuilder.Entity("LMSApi.Models.PatientRadHistoTestDetail", b =>
                {
                    b.Property<long>("PatientTestId")
                        .HasColumnType("bigint");

                    b.Property<int?>("SubTestId")
                        .HasColumnType("int");

                    b.Property<int>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<string>("InvestigationValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientTestId", "SubTestId", "InvestigationId");

                    b.ToTable("PatientRadHistoTestDetails");
                });

            modelBuilder.Entity("LMSApi.Models.PatientRadTest", b =>
                {
                    b.Property<long>("PatientTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PatientTestId"));

                    b.Property<string>("DiagnosisId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Report1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Report2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Report3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReportedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WaitingFor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientTestId");

                    b.ToTable("PatientRadTests");
                });

            modelBuilder.Entity("LMSApi.Models.PatientReferal", b =>
                {
                    b.Property<short>("ReferalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("ReferalId"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clinic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<DateOnly?>("DateofRegistration")
                        .HasColumnType("date");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("Percentage")
                        .HasColumnType("tinyint");

                    b.Property<string>("ReferalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReferalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("Region")
                        .HasColumnType("smallint");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ReferalId");

                    b.ToTable("PatientReferals");
                });

            modelBuilder.Entity("LMSApi.Models.PatientTest", b =>
                {
                    b.Property<long>("PatientTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PatientTestId"));

                    b.Property<double?>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime?>("DateTimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<short?>("Diagnose")
                        .HasColumnType("smallint");

                    b.Property<double?>("Discount")
                        .HasColumnType("float");

                    b.Property<byte>("LabId")
                        .HasColumnType("tinyint");

                    b.Property<string>("LabNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ParentPatientTestId")
                        .HasColumnType("bigint");

                    b.Property<int?>("ParentTestId")
                        .HasColumnType("int");

                    b.Property<long>("PatientId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("PerformDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RequestedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReversedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TerminalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<bool?>("TransacStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VerifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("VerifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PatientTestId");

                    b.ToTable("PatientTests");
                });

            modelBuilder.Entity("LMSApi.Models.PatientTestDetail", b =>
                {
                    b.Property<long>("PatientTestId")
                        .HasColumnType("bigint");

                    b.Property<int?>("SubTestId")
                        .HasColumnType("int");

                    b.Property<int>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<string>("InvestigationValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PatientTestId", "SubTestId", "InvestigationId");

                    b.ToTable("PatientTestDetails");
                });

            modelBuilder.Entity("LMSApi.Models.ReferalRegion", b =>
                {
                    b.Property<short>("RegionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("RegionId"));

                    b.Property<string>("RegionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RegionId");

                    b.ToTable("ReferalRegions");
                });

            modelBuilder.Entity("LMSApi.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TestId"));

                    b.Property<bool?>("AddDetail")
                        .HasColumnType("bit");

                    b.Property<string>("BloodQty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateTimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDefaultoParent")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSingle")
                        .HasColumnType("bit");

                    b.Property<byte?>("LabId")
                        .HasColumnType("tinyint");

                    b.Property<int?>("ParentTest")
                        .HasColumnType("int");

                    b.Property<short?>("RequiredTime")
                        .HasColumnType("smallint");

                    b.Property<int?>("TestCode")
                        .HasColumnType("int");

                    b.Property<string>("TestComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacutainer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("LMSApi.Models.TestAmount", b =>
                {
                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<byte>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<double?>("TestAmount1")
                        .HasColumnType("float");

                    b.Property<string>("TestComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TestReportName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TestId", "CompanyId");

                    b.ToTable("TestAmounts");
                });

            modelBuilder.Entity("LMSApi.Models.TestInvestigation", b =>
                {
                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int?>("SubTestId")
                        .HasColumnType("int");

                    b.Property<int>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<bool?>("BoldFont")
                        .HasColumnType("bit");

                    b.Property<string>("DefaultText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DisplayOrger")
                        .HasColumnType("int");

                    b.Property<bool?>("TestInvestIsDefault")
                        .HasColumnType("bit");

                    b.HasKey("TestId", "SubTestId", "InvestigationId");

                    b.ToTable("TestInvestigations");
                });

            modelBuilder.Entity("LMSApi.Models.TestSubType", b =>
                {
                    b.Property<int>("SubTestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubTestId"));

                    b.Property<string>("SubTestName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubTestId");

                    b.ToTable("TestSubTypes");
                });

            modelBuilder.Entity("LMSApi.Models.TestTemplate", b =>
                {
                    b.Property<short?>("LabId")
                        .HasColumnType("smallint");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Report1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Report2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Report3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LabId", "TestId");

                    b.ToTable("TestTemplates");
                });

            modelBuilder.Entity("LMSApi.Models.TestTemplatesDetail", b =>
                {
                    b.Property<int?>("TemplateId")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("InvestigationId")
                        .HasColumnType("int");

                    b.Property<int>("DetailId")
                        .HasColumnType("int");

                    b.Property<string>("InvestigationReport")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateId", "TestId", "InvestigationId");

                    b.ToTable("TestTemplatesDetails");
                });

            modelBuilder.Entity("LMSApi.Models.TestTemplatesMaster", b =>
                {
                    b.Property<int>("TemplateId")
                        .HasColumnType("int");

                    b.Property<int?>("TestId")
                        .HasColumnType("int");

                    b.Property<bool?>("ActiveStatus")
                        .HasColumnType("bit");

                    b.Property<string>("TemplateName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemplateId", "TestId");

                    b.ToTable("TestTemplatesMasters");
                });

            modelBuilder.Entity("LMSApi.Models.User", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte?>("CompanyId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LMSApi.Models.UserPermission", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte>("PermissionId")
                        .HasColumnType("tinyint");

                    b.HasKey("UserId", "PermissionId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("LMSApi.Models.Vacutainer", b =>
                {
                    b.Property<int>("VacutainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacutainerId"));

                    b.Property<string>("VacutainerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VacutainerId");

                    b.ToTable("Vacutainers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LMSApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LMSApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LMSApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LMSApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
