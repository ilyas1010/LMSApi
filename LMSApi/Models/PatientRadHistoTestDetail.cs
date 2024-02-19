using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;

[PrimaryKey(nameof(PatientTestId), nameof(SubTestId), nameof(InvestigationId))]
public partial class PatientRadHistoTestDetail
{
     public long PatientTestId { get; set; }

    public int? SubTestId { get; set; }

    public int InvestigationId { get; set; }

    public string? InvestigationValue { get; set; }
}
