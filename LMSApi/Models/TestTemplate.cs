using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(LabId), nameof(TestId))]
public partial class TestTemplate
{
    public short? LabId { get; set; }

    public int? TestId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string? Report1 { get; set; }

    public string? Report2 { get; set; }

    public string? Report3 { get; set; }

}
