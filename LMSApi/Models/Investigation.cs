using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;

public partial class Investigation
{
    [Key]
    public int InvestigationId { get; set; }

    public string InvestigationName { get; set; } = null!;

    public bool? IsSingle { get; set; }

    public bool? IsDefault { get; set; }

    public string? BloodQty { get; set; }

    public double? UnitPrice { get; set; }

    public string? UserId { get; set; }

    public string? TerminalId { get; set; }

}
