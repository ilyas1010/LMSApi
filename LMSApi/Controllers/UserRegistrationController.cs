using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using LMSApi.Models;
using LMSApi.ViewModels;

namespace LMSApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
    {
        // private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public UserRegistrationController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager

            )
        {
           _userManager = userManager;
           // _signInManager = signInManager;
            this.roleManager = roleManager;


        }
       
        [HttpPost]
        public async Task<IActionResult> Create(UserRegistration ur)
        {
            try
            {
          
            var user = new ApplicationUser { UserName = ur.UserId, Email = ur.Email, CompanyId = Convert.ToInt32(ur.Company), LabId = Convert.ToInt32(ur.Lab), FranchiseId = Convert.ToInt32(ur.Franchise), UserFullName = ur.UserName, IsFranchiseUser = ur.IsFranchiseUser };
                    var result = await _userManager.CreateAsync(user, ur.Password);
                    if (result.Succeeded)
                    {
                    return Created("",user);
                    }
                    else
                    {
                    return BadRequest(result.Errors);
                    }
                }
            
            catch (Exception ex)
            {
            return BadRequest();
            }
        

           
        }
        //public async Task<IActionResult> UpdateUser(UserRegistration ur)
        //{
        //    try
        //    {
        //        var user = await _userManager.FindByIdAsync(ur.UId);
        //        user.CompanyId =Convert.ToInt32( ur.Company);
        //        user.FranchiseId =Convert.ToInt32(ur.Franchise);
        //        user.UserFullName = ur.UserName;
        //        user.IsFranchiseUser = ur.IsFranchiseUser;
        //        user.Email = ur.Email;
        //        var result = _userManager.UpdateAsync(user);
        //            if (result.Result.Succeeded)
        //            {
        //                await AddUpdateUsersInRole(ur, user);
        //                return Json("Updated");
        //            }
        //            else
        //            {
        //                var error = "";
        //                foreach (var resultError in result.Result.Errors)
        //                {
        //                    error = resultError.Description;
        //                }
        //                return Json(error);
        //            }
                
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json("Error");
        //    }


        //}
        //[HttpGet]
        //public async Task<IActionResult> Update(string UserId)
        //{
        //    UserRegistration ur = new UserRegistration();


        //   var user = await _userManager.FindByIdAsync(UserId);
        //    if (user != null)
        //    {
        //        ur.Company = user.CompanyId;
        //        ur.Franchise = user.FranchiseId;
        //        ur.UserName = user.UserFullName;
        //        ur.UserId = user.UserName;
        //        ur.UId = user.Id;
        //        ur.Password = user.PasswordHash;
        //        ur.ConfirmPassword = user.PasswordHash;
        //        ur.IsFranchiseUser = user.IsFranchiseUser;
        //        ur.Email = user.Email;
        //        ur.IsEdit = true;
        //        return View("Create", ur);
        //    }
        //    else { return null; }
        //}
        //[HttpGet]
        //public async Task<IActionResult> Delete(string UserId)
        //{
        //    UserRegistration ur = new UserRegistration();


        //    var user = await _userManager.FindByIdAsync(UserId);
        //    if (user != null)
        //    {
        //        ur.Company = user.CompanyId;
        //        ur.Franchise = user.FranchiseId;
        //        ur.UserName = user.UserFullName;
        //        ur.UserId = user.UserName;
        //        ur.UId = user.Id;
        //        ur.Password = user.PasswordHash;
        //        ur.ConfirmPassword = user.PasswordHash;
        //        ur.IsFranchiseUser = user.IsFranchiseUser;
        //        ur.Email = user.Email;
        //        ur.IsEdit = true;
        //        return View("Delete", ur);
        //    }
        //    else { return null; }
        //}
        //[HttpPost]
        //public async Task<IActionResult> DeleteById(string UserId)
        //{

        //    try
        //    {
        //        var user = await _userManager.FindByIdAsync(UserId);
        //        var result = _userManager.DeleteAsync(user);
        //        if (result.Result.Succeeded)
        //        {
        //            return View("Index");
        //        }
        //        else
        //        {
        //            var error = "";
        //            foreach (var resultError in result.Result.Errors)
        //            {
        //                error = resultError.Description;
        //            }
        //            return Json(error);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return Json("Error");
        //    }

        //}
        //public object LoadUsersList()
        //{
        //    var userlist = _userManager.Users;

        //    //return DataSourceLoader.Load(companylist, loadOptioins);
        //    return Json(userlist);
        //}
       
        //[HttpGet]

        //public async Task<object> GetRoles(string UserId)
        //{
        //    try
        //    {
        //        var savedUser = await _userManager.FindByIdAsync(UserId);

        //        //var roles = roleManager.Roles;
        //        List<UserRole> lstUserRoles = new List<UserRole>();
        //        foreach (var role in roleManager.Roles)
        //        {
        //            UserRole userRole = new UserRole{RoleId=role.Id,RoleName=role.Name };
                   
        //            lstUserRoles.Add(userRole);
        //        }
        //        for(int i=0;i<lstUserRoles.Count;i++)
        //        {
        //            if (savedUser != null && await _userManager.IsInRoleAsync(savedUser, lstUserRoles[i].RoleName))
        //                lstUserRoles[i].IsSelected = true;
        //            else
        //                lstUserRoles[i].IsSelected = false;
        //        }
        //        return Json(lstUserRoles);
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;

        //    }

            
        //}
       
    }


