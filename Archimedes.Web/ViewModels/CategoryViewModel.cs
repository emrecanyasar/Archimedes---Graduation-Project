using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public string CategoryName { get; set; }
    }
}
