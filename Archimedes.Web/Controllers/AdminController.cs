using Archimedes.Business.Abstract;
using Archimedes.Entity;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archimedes.Web.Controllers
{
    public class AdminController : BaseController
    {
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,ICategoryService categoryService) : base(userManager, signInManager, categoryService)
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

    }
}
