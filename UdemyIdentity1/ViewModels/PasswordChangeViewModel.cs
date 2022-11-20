using System.ComponentModel.DataAnnotations;

namespace UdemyIdentity.ViewModels
{
    public class PasswordChangeViewModel
    {
        [Display(Name ="Eski Şifreniz")]
        [Required(ErrorMessage ="Eski şifreniz gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(1,ErrorMessage ="Şifreniz en az 4 karakterli olmalıdır.")]
        public string PasswordOld { get; set; }
        [Display(Name = "Yeni Şifreniz")]
        [Required(ErrorMessage = "Yeni şifreniz gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(1, ErrorMessage = "Şifreniz en az 4 karakterli olmalıdır.")]
        public string PasswordNew { get; set; }
        [Display(Name = "Tekrar yeni Şifreniz")]
        [Required(ErrorMessage = "Yeni şifre tekrar gereklidir.")]
        [DataType(DataType.Password)]
        [MinLength(1, ErrorMessage = "Şifreniz en az 4 karakterli olmalıdır.")]
        [Compare("PasswordNew",ErrorMessage ="Yeni şifreniz onay şifrenizle aynı değildir")]
        public string PasswordConfirm { get; set; }
    }
}
