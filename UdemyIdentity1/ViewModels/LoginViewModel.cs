using System.ComponentModel.DataAnnotations;

namespace UdemyIdentity.ViewModels
{
    public class LoginViewModel 
    {
        [Required(ErrorMessage = "Email Alanı Gereklidir!")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru değil.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [MinLength(4,ErrorMessage ="Şifreniz en az 4 karakterli olmalıdır.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }

}
