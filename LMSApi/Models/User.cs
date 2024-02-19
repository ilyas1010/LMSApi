using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
[PrimaryKey(nameof(UserId))]
public partial class User
{
    public string UserId { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? Designation { get; set; }

    public bool? Status { get; set; }

    public byte? CompanyId { get; set; }

    public DateTime? RegistrationDate { get; set; }

}
