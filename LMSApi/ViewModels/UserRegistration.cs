using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LMSApi.ViewModels;
public class UserRegistration
{
    public UserRegistration()
    {

    }
    public string UId { get; set; }
    [Required]
    [Key]
    [MaxLength(50)]
    public string? UserId { get; set; }
    [Required]
    [MaxLength(50)]
    public string? UserName { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    [RegularExpression(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$", ErrorMessage = "Invalid Email Address.")]
    public string Email { get; set; }

    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password { get; set; }
    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Confirm password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
    [Required]
    public int? Company { get; set; }
    public int? Lab { get; set; }
    [Required]
    public int? Franchise { get; set; }
    public bool IsFranchiseUser { get; set; }
    public bool IsEdit { get; set; }

}

