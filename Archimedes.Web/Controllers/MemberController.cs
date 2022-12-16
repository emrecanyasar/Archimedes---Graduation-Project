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


        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService, IShopListService shopListService) : base(userManager, signInManager, categoryService, productService, shopListService)
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
        public async Task<IActionResult> CreateList()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateList(ShopListViewModel shopList, string userId)
        {
            var name = HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(name);
            var entity = new ShopList()
            {
                ShopListName = shopList.ShopListName,
            };
            userId = user.Id;
            _shopListService.Create(entity,userId);

            //shopList.Users = userId.Select(catId => catId == user.Id).FirstOrDefault();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> MyList()
        {
            var user = HttpContext.User.Identity.Name;
            var userInfo = await _userManager.FindByNameAsync(user);
            var userId = userInfo.Id;
            var mylist = _shopListService.GetShopListByUser(userId);
            return View(mylist);
        }
        [HttpGet]
        public async Task<IActionResult> ListEdit(int id)
        {
            var entity = await _categoryService.GetById(id);
            var cateentity = new CategoryViewModel()
            {
                CategoryId = entity.Id,
                CategoryName = entity.CategoryName
            };
            return View(cateentity);
        }
        [HttpPost]
        public async Task<IActionResult> ListEdit(CategoryViewModel categoryViewModel)
        {
            var entity = await _categoryService.GetById(categoryViewModel.CategoryId);
            entity.CategoryName = categoryViewModel.CategoryName;
            _categoryService.Update(entity);
            return RedirectToAction("Categories");

        }

        public async Task<IActionResult> DeleteList(int shopListId)
        {
            var shopList = await _shopListService.GetById(shopListId);
            if (shopList != null)
            {
                _shopListService.Delete(shopList);
            }
            return RedirectToAction("MyList");
        }
        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetAll();
            return View(categories);
        }
        public IActionResult CategoryList(string category)
        {
            var products = _productService.GetProductsByCategory(category);
            return View(products);
        }
    }
}
