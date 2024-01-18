using System.ComponentModel.DataAnnotations;

namespace LunchBoxAdmin.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
