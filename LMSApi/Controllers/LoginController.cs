using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using LMSApi.Models;
using LMSApi.ViewModels;
using Azure.Core;

namespace LMSApi.Controllers;

[ApiController]
[Route("[controller]")]
public class LoginController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public LoginController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
         }

    [HttpPost]
    public async Task<IActionResult> Login(Login login)
    {
        var user = await _userManager.FindByNameAsync(login.UserId);
        if (user == null)
        {
            return NotFound("Invalid User Id");
        }

        var isPasswordValid = await _userManager.CheckPasswordAsync(user,login.Password);

        if (!isPasswordValid)
        {
            return NotFound("Invalid Password");
        }
        return Ok(user);

    }
    }

