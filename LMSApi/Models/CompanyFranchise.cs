using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LMSApi.Models;

public class CompanyFranchise
{
    [Key]
    public int FranchiseId { get; set; }

    public short? CompanyId { get; set; }

    public string? FranchiseName { get; set; }

    public bool? Status { get; set; }
}
