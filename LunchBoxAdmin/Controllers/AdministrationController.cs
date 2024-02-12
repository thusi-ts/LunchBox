using LunchBox.Shared;
using LunchBoxAdmin.Models;
using LunchBoxAdmin.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LunchBoxAdmin.Controllers
{
    [Authorize(Policy = "CanAccessAdmin")]
    public class AdministrationController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<User> signInManager;

        public AdministrationController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = userManager.Users;

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> EditUser(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {Id} cannot be found";
                return View("NotFound");
            }

            var userRoles = await userManager.GetRolesAsync(user);
            var _roles = new List<RoleViewModel>();
            foreach (var role in roleManager.Roles)
            {
                if (role.Name == RolesStore.SuperAdministrator) continue;

                var _roleViewModel = new RoleViewModel { Id = role.Id, Name = role.Name };
                if (userRoles.Any(r => r.Equals(role.Name))) {
                    _roleViewModel.IsSelected = true; 
                }
                _roles.Add(_roleViewModel);
            }

            var allClaims = ClaimsStore.GetAllClaims;
            var userSelectedClaims = await userManager.GetClaimsAsync(user);
            var claimViewModel = new List<ClaimViewModel>();

            foreach (var claim in allClaims)
            {
                var claimModel = new ClaimViewModel
                {
                    ClaimType = claim.Type
                };

                if(userSelectedClaims.Any(c => c.Type == claim.Type)) claimModel.IsSelected = true ;
                claimViewModel.Add(claimModel);
            }

            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                City = user.City,
                UserClaims = claimViewModel,
                Roles = _roles, //roleManager.Roles.Select(r => new RoleViewModel { Id = r.Id, Name = r.Name }).ToList(),
            };

            return View(model);
        }
        [Authorize(Policy = "SuperAdminRolePolicy")]
        [HttpPost]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.City = model.City;
                user.UserName = model.UserName;
                var userUpdateresult = await userManager.UpdateAsync(user);

                if (userUpdateresult.Succeeded)
                {
                    var rolesInDB = await userManager.GetRolesAsync(user);
                    var roleDeleteresult = await userManager.RemoveFromRolesAsync(user, rolesInDB.ToList<String>()); // delete all users role already selected in DB

                    if (!roleDeleteresult.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot remove user existing roles");
                        return View(model);
                    }

                    var selectedRoles = model.Roles.Where(r => r.IsSelected).Select(r => r.Name);
                    var addUserRoleResult = await userManager.AddToRolesAsync(user, selectedRoles);  // Add all selected user roles

                    if (!addUserRoleResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot add selected Roles to user");
                        return View(model);
                    }

                    var claims = await userManager.GetClaimsAsync(user);
                    var claimDeleteResult = await userManager.RemoveClaimsAsync(user, claims);

                    if (!claimDeleteResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot remove user existing claims");
                        return View(model);
                    }

                    var selectedClaims = model.UserClaims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, "true"));
                    var addUserClaimResult = await userManager.AddClaimsAsync(user, selectedClaims);

                    if (!addUserClaimResult.Succeeded)
                    {
                        ModelState.AddModelError("", "Cannot add selected Claims to user");
                        return View(model);
                    }

                    return RedirectToAction("Index");
                }

                foreach (var error in userUpdateresult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {Id} cannot be found";
                return View("NotFound");
            }
            ViewBag.UserName = user.UserName;
            var userHasPassword = await userManager.HasPasswordAsync(user);

            if (!userHasPassword)
            {
                return RedirectToAction("AddPassword");
            }

            return View();
        }

        [HttpPost]
        [Authorize(Policy = "SuperAdminRolePolicy")]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByIdAsync(model.Id);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                var result = await userManager.ChangePasswordAsync(user, model.CurrentPassword, model.NewPassword);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
