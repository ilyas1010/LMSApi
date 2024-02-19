using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace LMSApi.Models;

public class ApplicationUser : IdentityUser
{
    public int CompanyId { get; set; }
    public string? CompanyName { get; set; }
    public int LabId { get; set; }
    public int FranchiseId { get; set; }
    public string? UserFullName { get; set; }
    public bool IsFranchiseUser { get; set; }
    
}
