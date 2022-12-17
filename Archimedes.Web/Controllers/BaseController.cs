using Archimedes.Business.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archimedes.Web.Controllers
{
    public class BaseController : Controller
    {
        public UserManager<AppUser> _userManager { get; }
        public SignInManager<AppUser> _signInManager { get; }
        public ArchimedeDbContext _archimedeDbContext;

        protected AppUser CurrentUser => _userManager.FindByNameAsync(User.Identity.Name).Result;

        public ICategoryService _categoryService;
        public IProductService _productService;
        public IShopListService _shopListService;
        public IShopListDetailService _shopListDetailService;
        public IUserShopListService _userShopListService;
        public BaseController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService, IShopListService shopListService, IShopListDetailService shopListDetailService, ArchimedeDbContext archimedeDbContext, IUserShopListService userShopListService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _categoryService = categoryService;
            _productService = productService;
            _shopListService = shopListService;
            _shopListDetailService = shopListDetailService;
            _archimedeDbContext = archimedeDbContext;
            _userShopListService = userShopListService;

        }
        public void AddModelError(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
    }
}
