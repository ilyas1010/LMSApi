using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(TemplateId), nameof(TestId),nameof(InvestigationId))]
public partial class TestTemplatesDetail
{
    public int DetailId { get; set; }

    public int? TemplateId { get; set; }

    public int TestId { get; set; }

    public int InvestigationId { get; set; }

    public string? InvestigationReport { get; set; }
}
