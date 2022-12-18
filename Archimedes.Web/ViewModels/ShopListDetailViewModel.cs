using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class ShopListDetailViewModel
    {
        public int ShopListId { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Açıklama alanı zorunlu bir alandır!")]
        [StringLength(120, MinimumLength = 5, ErrorMessage = "Açıklama 5-120 karakter arasında bir uzunluğa sahip olmalıdır!")]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
