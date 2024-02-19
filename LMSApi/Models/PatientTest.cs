using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(PatientTestId))]
public partial class PatientTest
{

    public long PatientTestId { get; set; }

    public long PatientId { get; set; }

    public int? TestId { get; set; }

    public byte LabId { get; set; }

    public string? LabNo { get; set; }

    public double? Amount { get; set; }

    public double? Discount { get; set; }

    public DateTime? RequestedDate { get; set; }

    public DateTime? PerformDate { get; set; }

    public DateTime? VerifiedDate { get; set; }

    public string? VerifiedBy { get; set; }

    public DateTime? DateTimeStamp { get; set; }

    public string? UserId { get; set; }

    public string? TerminalId { get; set; }

    public string? Remarks { get; set; }

    public bool? TransacStatus { get; set; }

    public short? Diagnose { get; set; }

    public string? ReversedBy { get; set; }

    public int? ParentTestId { get; set; }

    public long? ParentPatientTestId { get; set; }

}
