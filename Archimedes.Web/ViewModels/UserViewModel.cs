using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "Kullanıcı ismi gereklidir!")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Ad")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Display(Name = "Tel No:")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Email Adresi Gereklidir!")]
        [Display(Name = "Email Adresiniz")]
        [EmailAddress(ErrorMessage = "Email adresiniz doğru değil")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]
        [Display(Name = "Şifre Giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Doğum Tarihi ")]
        public DateTime? BirthDay { get; set; }
        public string Picture { get; set; }
        [Display(Name = "Şehir")]
        public string City { get; set; }
    }
}
