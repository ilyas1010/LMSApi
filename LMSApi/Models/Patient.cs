using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;

public partial class Patient
{
    [Key]
    public long PatientId { get; set; }

    public string PatientCode { get; set; } = null!;

    public long? RegisterNo { get; set; }

    public long? FranchiseNo { get; set; }

    public string? FirstName { get; set; }

    public string? SecondName { get; set; }

    public string? FatherName { get; set; }

    public string? Nicno { get; set; }

    public string? MobileNo { get; set; }

    public byte? Age { get; set; }

    public string? AgeDesc { get; set; }

    public byte? SexCode { get; set; }

    public byte? CompanyId { get; set; }

    public byte? FranchiseId { get; set; }

    public short? ReferalId { get; set; }

    public DateTime? DateTimeStamp { get; set; }

    public bool? PatientStatus { get; set; }

    public string? ReferedBy { get; set; }

    public string? Address { get; set; }

    public string? Email { get; set; }

    public decimal? AmountReceived { get; set; }

    public double? AmountDue { get; set; }

    public double? TotalAmount { get; set; }

    public bool? SampleDesc { get; set; }

    public string? UserId { get; set; }

    public string? TerminalId { get; set; }
    public int MigrationTest { get; set; }

}
