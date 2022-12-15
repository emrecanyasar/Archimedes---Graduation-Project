using Archimedes.Business.Abstract;
using Archimedes.Entity;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archimedes.Web.Controllers
{
    //[Authorize]
    public class MemberController : BaseController
    {
        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService) : base(userManager, signInManager, categoryService, productService)
        {

        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var entity = await _productService.GetAllProducts();
            return View(entity);
        }

        [HttpGet]
        public async Task<IActionResult> MemberProfile()
        {
            var name = HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(name);
            var uservm = new UserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                UserName = user.UserName
            };
            return View(uservm);
        }

        public IActionResult Search(string search)
        {
            var searchList= _productService.GetSearchResult(search);
            return View(searchList);
        }

        [HttpGet]
        public IActionResult CreateList()
        {
            return View();
        }
    }
}
