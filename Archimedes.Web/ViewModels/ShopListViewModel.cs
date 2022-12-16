using Archimedes.Entity;

namespace Archimedes.Web.ViewModels
{
    public class ShopListViewModel
    {
        public int ShopListId { get; set; }
        public string ShopListName { get; set; }
        public List<AppUser> Users { get; set; }

    }
}
