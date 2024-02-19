using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(TestId), nameof(SubTestId), nameof(InvestigationId))]
public partial class TestInvestigation
{
    public int TestId { get; set; }

    public int? SubTestId { get; set; }

    public int InvestigationId { get; set; }

    public int? DisplayOrger { get; set; }

    public bool? TestInvestIsDefault { get; set; }

    public bool? BoldFont { get; set; }

    public string? DefaultText { get; set; }

}
