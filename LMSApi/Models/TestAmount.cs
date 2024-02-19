using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(TestId),nameof(CompanyId))]
public partial class TestAmount
{
    public int TestId { get; set; }

    public byte CompanyId { get; set; }

    public double? TestAmount1 { get; set; }

    public string? TestComments { get; set; }

    public string? TestReportName { get; set; }

    
}
