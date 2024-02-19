using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;

public class CompanyDoctor
{
    [Key]
    public int DocId { get; set; }

    public byte? CompanyId { get; set; }

    public string? Doctor { get; set; }

    public string? Qualification1 { get; set; }

    public string? Qualification2 { get; set; }

    public string? Qualification3 { get; set; }

    public bool? Status { get; set; }

    public int? Order { get; set; }
}
