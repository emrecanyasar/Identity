using System.ComponentModel.DataAnnotations;

namespace UdemyIdentity.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage ="Kullanıcı ismi gereklidir!")]
        [Display(Name ="Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name = "Tel No:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Adresi Gereklidir!")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage ="Email adresiniz doğru değil")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]
        [Display(Name = "Şifre Giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
