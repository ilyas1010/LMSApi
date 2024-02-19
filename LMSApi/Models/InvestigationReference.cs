using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LMSApi.Models;

[PrimaryKey(nameof(TempPk))]
public partial class InvestigationReference
{
   
    public int InvestigationId { get; set; }

    public byte? CompanyId { get; set; }

    public int TestId { get; set; }

    public string? AgeRange { get; set; }

    public string? MExpMin { get; set; }

    public string? MExpMax { get; set; }

    public string? FExpMin { get; set; }

    public string? FExpMax { get; set; }

    public string? Unit { get; set; }

    public string? CriticalValue { get; set; }

    public string? Comments { get; set; }

    public int TempPk { get; set; }

   
}
