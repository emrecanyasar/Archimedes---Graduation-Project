using Archimedes.Entity;
using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Name alanı zorunlu bir alandır!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Name 5-50 karakter arasında bir uzunluğa sahip olmalıdır!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price alanı zorunlu bir alandır!")]
        [Range(1, 30000, ErrorMessage = "Price 1-30000 arasında olmalıdır!")]
        public long Price { get; set; }

        [Required(ErrorMessage = "Image url alanı zorunlu bir alandır!")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Url alanı zorunlu bir alandır!")]
        public Category SelectedCategories { get; set; }

    }
}
