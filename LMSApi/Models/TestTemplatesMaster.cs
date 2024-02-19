using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(TemplateId),nameof(TestId))]
public partial class TestTemplatesMaster
{
    public int TemplateId { get; set; }

    public int? TestId { get; set; }

    public string? TemplateName { get; set; }

    public bool? ActiveStatus { get; set; }

    public string? UserId { get; set; }
}
