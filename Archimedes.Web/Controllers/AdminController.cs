using Archimedes.Business.Abstract;
using Archimedes.Entity;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Archimedes.Web.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,ICategoryService categoryService,IProductService productService) : base(userManager, signInManager, categoryService,productService)
        {

        }
        public async Task<IActionResult> Index()
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

        public async Task<IActionResult> Categories()
        {
            var categories = await _categoryService.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CategoryCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryCreate(CategoryViewModel model)
        {
            //Gelen productı alıp EF Core aracılığıyla veritabanına kaydetmem lazım gerekiyor
            var category = new Category()
            {
                CategoryName = model.CategoryName
            };
            
            _categoryService.Create(category);

            return RedirectToAction("Categories");
        }
        [HttpGet]
        public async Task<IActionResult> CategoryEdit(int id)
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
        public async Task<IActionResult> CategoryEdit(CategoryViewModel categoryViewModel)
        {
            var entity = await _categoryService.GetById(categoryViewModel.CategoryId);
            entity.CategoryName = categoryViewModel.CategoryName;
            _categoryService.Update(entity);
            return RedirectToAction("Categories");

        }

        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var category = await _categoryService.GetById(categoryId);
            if (category != null)
            {
                _categoryService.Delete(category);
            }
            return RedirectToAction("Categories");
        }

        public async Task<IActionResult> Products()
        {
            var categories = await _productService.GetAll();
            return View(categories);
        }
        [HttpGet]
        public IActionResult ProductsCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProductsCreate(ProductViewModel model)
        {
            //Gelen productı alıp EF Core aracılığıyla veritabanına kaydetmem lazım gerekiyor
            var product = new Product()
            {
                ProductName = model.Name,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                CreatedTime =model.CreatedDate,
                CategoryId = model.categoryId
            };
            _productService.Create(product);

            return RedirectToAction("Products");
        }

    }
}
