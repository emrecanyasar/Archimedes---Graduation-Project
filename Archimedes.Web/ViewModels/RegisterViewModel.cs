using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı gereklidir.")]
        [Display(Name = "Kullanıcı Adı")]
        [MaxLength(15)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email alanı gereklidir.")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Telefon Numarası")]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
