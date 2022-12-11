using System.ComponentModel.DataAnnotations;

namespace Archimedes.Web.ViewModels
{
    public class CategoryViewModel
    {
        [Display(Name = "Email")]
        public string CategoryName { get; set; }
    }
}
