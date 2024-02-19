using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(PatientTestId))]
public partial class PatientRadTest
{
    public long PatientTestId { get; set; }

    public string? DiagnosisId { get; set; }

    public string? Report1 { get; set; }

    public string? Report2 { get; set; }

    public string? Report3 { get; set; }

    public string? ReportedBy { get; set; }

    public string? WaitingFor { get; set; }

    
}
