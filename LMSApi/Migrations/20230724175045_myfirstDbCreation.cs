using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LMSApi.Migrations
{
    /// <inheritdoc />
    public partial class myfirstDbCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyStatus = table.Column<bool>(type: "bit", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FontSize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FontStyle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyDoctors",
                columns: table => new
                {
                    DocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: true),
                    Doctor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qualification3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyDoctors", x => x.DocId);
                });

            migrationBuilder.CreateTable(
                name: "CompanyFranchises",
                columns: table => new
                {
                    FranchiseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<short>(type: "smallint", nullable: true),
                    FranchiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyFranchises", x => x.FranchiseId);
                });

            migrationBuilder.CreateTable(
                name: "InvestigationReferences",
                columns: table => new
                {
                    InvestigationId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    AgeRange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MExpMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MExpMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FExpMin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FExpMax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CriticalValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempPk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestigationReferences", x => new { x.InvestigationId, x.CompanyId, x.TestId });
                });

            migrationBuilder.CreateTable(
                name: "Investigations",
                columns: table => new
                {
                    InvestigationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestigationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSingle = table.Column<bool>(type: "bit", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    BloodQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigations", x => x.InvestigationId);
                });

            migrationBuilder.CreateTable(
                name: "Labs",
                columns: table => new
                {
                    LabId = table.Column<byte>(type: "tinyint", nullable: false),
                    LabName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labs", x => x.LabId);
                });

            migrationBuilder.CreateTable(
                name: "PatientDiagnoses",
                columns: table => new
                {
                    DiagnoseId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnoseName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientDiagnoses", x => x.DiagnoseId);
                });

            migrationBuilder.CreateTable(
                name: "PatientRadHistoTestDetails",
                columns: table => new
                {
                    PatientTestId = table.Column<long>(type: "bigint", nullable: false),
                    SubTestId = table.Column<int>(type: "int", nullable: false),
                    InvestigationId = table.Column<int>(type: "int", nullable: false),
                    InvestigationValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRadHistoTestDetails", x => new { x.PatientTestId, x.SubTestId, x.InvestigationId });
                });

            migrationBuilder.CreateTable(
                name: "PatientRadTests",
                columns: table => new
                {
                    PatientTestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagnosisId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WaitingFor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientRadTests", x => x.PatientTestId);
                });

            migrationBuilder.CreateTable(
                name: "PatientReferals",
                columns: table => new
                {
                    ReferalId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: true),
                    ReferalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percentage = table.Column<byte>(type: "tinyint", nullable: true),
                    DateofRegistration = table.Column<DateOnly>(type: "date", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<short>(type: "smallint", nullable: true),
                    Clinic = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientReferals", x => x.ReferalId);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegisterNo = table.Column<long>(type: "bigint", nullable: true),
                    FranchiseNo = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nicno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<byte>(type: "tinyint", nullable: true),
                    AgeDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SexCode = table.Column<byte>(type: "tinyint", nullable: true),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: true),
                    FranchiseId = table.Column<byte>(type: "tinyint", nullable: true),
                    ReferalId = table.Column<short>(type: "smallint", nullable: true),
                    DateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PatientStatus = table.Column<bool>(type: "bit", nullable: true),
                    ReferedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountReceived = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    AmountDue = table.Column<double>(type: "float", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    SampleDesc = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "PatientTestDetails",
                columns: table => new
                {
                    PatientTestId = table.Column<long>(type: "bigint", nullable: false),
                    SubTestId = table.Column<int>(type: "int", nullable: false),
                    InvestigationId = table.Column<int>(type: "int", nullable: false),
                    InvestigationValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTestDetails", x => new { x.PatientTestId, x.SubTestId, x.InvestigationId });
                });

            migrationBuilder.CreateTable(
                name: "PatientTests",
                columns: table => new
                {
                    PatientTestId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: true),
                    LabId = table.Column<byte>(type: "tinyint", nullable: false),
                    LabNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PerformDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VerifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeStamp = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminalId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransacStatus = table.Column<bool>(type: "bit", nullable: true),
                    Diagnose = table.Column<short>(type: "smallint", nullable: true),
                    ReversedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTestId = table.Column<int>(type: "int", nullable: true),
                    ParentPatientTestId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTests", x => x.PatientTestId);
                });

            migrationBuilder.CreateTable(
                name: "ReferalRegions",
                columns: table => new
                {
                    RegionId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferalRegions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "TestAmounts",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: false),
                    TestAmount1 = table.Column<double>(type: "float", nullable: true),
                    TestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestReportName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestAmounts", x => new { x.TestId, x.CompanyId });
                });

            migrationBuilder.CreateTable(
                name: "TestInvestigations",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false),
                    SubTestId = table.Column<int>(type: "int", nullable: false),
                    InvestigationId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrger = table.Column<int>(type: "int", nullable: true),
                    TestInvestIsDefault = table.Column<bool>(type: "bit", nullable: true),
                    BoldFont = table.Column<bool>(type: "bit", nullable: true),
                    DefaultText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestInvestigations", x => new { x.TestId, x.SubTestId, x.InvestigationId });
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    TestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestCode = table.Column<int>(type: "int", nullable: true),
                    LabId = table.Column<byte>(type: "tinyint", nullable: true),
                    TestName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodQty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacutainer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequiredTime = table.Column<short>(type: "smallint", nullable: true),
                    DisplayOrder = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    IsSingle = table.Column<bool>(type: "bit", nullable: true),
                    AddDetail = table.Column<bool>(type: "bit", nullable: true),
                    TestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTest = table.Column<int>(type: "int", nullable: true),
                    IsDefaultoParent = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.TestId);
                });

            migrationBuilder.CreateTable(
                name: "TestSubTypes",
                columns: table => new
                {
                    SubTestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubTestName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSubTypes", x => x.SubTestId);
                });

            migrationBuilder.CreateTable(
                name: "TestTemplates",
                columns: table => new
                {
                    LabId = table.Column<short>(type: "smallint", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Report1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Report3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTemplates", x => new { x.LabId, x.TestId });
                });

            migrationBuilder.CreateTable(
                name: "TestTemplatesDetails",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    InvestigationId = table.Column<int>(type: "int", nullable: false),
                    DetailId = table.Column<int>(type: "int", nullable: false),
                    InvestigationReport = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTemplatesDetails", x => new { x.TemplateId, x.TestId, x.InvestigationId });
                });

            migrationBuilder.CreateTable(
                name: "TestTemplatesMasters",
                columns: table => new
                {
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    TestId = table.Column<int>(type: "int", nullable: false),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTemplatesMasters", x => new { x.TemplateId, x.TestId });
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    PermissionId = table.Column<byte>(type: "tinyint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => new { x.UserId, x.PermissionId });
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    CompanyId = table.Column<byte>(type: "tinyint", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "CompanyDoctors");

            migrationBuilder.DropTable(
                name: "CompanyFranchises");

            migrationBuilder.DropTable(
                name: "InvestigationReferences");

            migrationBuilder.DropTable(
                name: "Investigations");

            migrationBuilder.DropTable(
                name: "Labs");

            migrationBuilder.DropTable(
                name: "PatientDiagnoses");

            migrationBuilder.DropTable(
                name: "PatientRadHistoTestDetails");

            migrationBuilder.DropTable(
                name: "PatientRadTests");

            migrationBuilder.DropTable(
                name: "PatientReferals");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "PatientTestDetails");

            migrationBuilder.DropTable(
                name: "PatientTests");

            migrationBuilder.DropTable(
                name: "ReferalRegions");

            migrationBuilder.DropTable(
                name: "TestAmounts");

            migrationBuilder.DropTable(
                name: "TestInvestigations");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "TestSubTypes");

            migrationBuilder.DropTable(
                name: "TestTemplates");

            migrationBuilder.DropTable(
                name: "TestTemplatesDetails");

            migrationBuilder.DropTable(
                name: "TestTemplatesMasters");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
