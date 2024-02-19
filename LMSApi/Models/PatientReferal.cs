using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(ReferalId))]
public partial class PatientReferal
{
    public short ReferalId { get; set; }

    public byte? CompanyId { get; set; }

    public string? ReferalCode { get; set; }

    public string? ReferalName { get; set; }

    public byte? Percentage { get; set; }

    public DateOnly? DateofRegistration { get; set; }

    public bool? Status { get; set; }

    public string? MobileNo { get; set; }

    public short? Region { get; set; }

    public string? Clinic { get; set; }

    public string? Address { get; set; }
}
