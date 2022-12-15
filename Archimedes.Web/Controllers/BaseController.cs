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

        protected AppUser CurrentUser => _userManager.FindByNameAsync(User.Identity.Name).Result;

        public ICategoryService _categoryService;
        public IProductService _productService;
        public BaseController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,ICategoryService categoryService, IProductService productService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _categoryService = categoryService;
            _productService = productService;
        }
    }
}
