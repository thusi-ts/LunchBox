using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace LunchBoxAdmin.ViewModels
{
    public class EditUserViewModel
    {
        public EditUserViewModel()
        {
            UserClaims = new List<ClaimViewModel>();
            Roles = new List<RoleViewModel>();
        }
        public string Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "The Email field is not a valid e-mail address.")]
        public string UserName { get; set; }

        public string City { get; set; }

        public IList<ClaimViewModel> UserClaims { get; set; }

        public IList<RoleViewModel> Roles { get; set; }
    }
}
