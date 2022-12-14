using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
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
        [MinLength(4, ErrorMessage = "Şifreniz en az 4 karakterli olmalıdır.")]
        public string Password { get; set; }
    }
}
