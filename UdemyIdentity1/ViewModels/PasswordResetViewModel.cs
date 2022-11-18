using System.ComponentModel.DataAnnotations;

namespace UdemyIdentity.ViewModels
{
    public class PasswordResetViewModel
    {
        [Required(ErrorMessage = "Email Alanı Gereklidir!")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru değil.")]
        public string Email { get; set; }
    }
}
