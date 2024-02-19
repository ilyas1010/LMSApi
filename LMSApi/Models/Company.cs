using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LMSApi.Models;
public  class Company
{
    [Key]
    public byte CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Description { get; set; }

    public string? Address { get; set; }

    public bool? CompanyStatus { get; set; }

    public DateTime? RegistrationDate { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? FontSize { get; set; }

    public string? FontStyle { get; set; }

   
}
