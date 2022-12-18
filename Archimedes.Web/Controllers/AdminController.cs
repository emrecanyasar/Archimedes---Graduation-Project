using Archimedes.Business.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Archimedes.Web.Controllers
{
    [Authorize(Roles = "ADMIN")]
    public class AdminController : BaseController
    {
        public AdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService, IShopListService shopListService, IShopListDetailService shopListDetailService, ArchimedeDbContext archimedeDbContext, IUserShopListService userShopListService) : base(userManager, signInManager, categoryService, productService, shopListService, shopListDetailService, archimedeDbContext, userShopListService)
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

            var category = new Category()
            {
                CategoryName = model.CategoryName
            };
            var cate = _categoryService.GetCategoryByName(category.CategoryName)==null;
            if (!cate)
            {
                ModelState.AddModelError("", "Böyle bir kategori zaten mevcut!");
                return View(model);
            }
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
            var products = await _productService.GetAllProducts();

            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> ProductsCreate()
        {
            ViewBag.Categories = await _categoryService.GetAll();
            List<Category> categories =await _categoryService.GetAll();
            ViewBag.Category = new SelectList(categories, "Id", "CategoryName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductsCreate(Product model)
        {

            List<Category> categories = await _categoryService.GetAll();
            ViewBag.Category = new SelectList(categories, "Id", "CategoryName");
            var entity = new Product()
            {
                ProductName = model.ProductName,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                CategoryId = model.CategoryId,
            };
            var pro = _productService.GetProductByName(model.ProductName) == null;
            if (!pro)
            {
                ModelState.AddModelError("", "Bu isimde bir ürün zaten mevcut!");
                return View(model);
            }

            _productService.Create(entity);
            ViewBag.Categories = await _categoryService.GetAll();
            return RedirectToAction("Products");
        }

        [HttpGet]
        public async Task<IActionResult> ProductsEdit(int id)
        {
            List<Category> categories = await _categoryService.GetAll();
            ViewBag.Category = new SelectList(categories, "Id", "CategoryName");
            var entity = await _productService.GetById(id);
            var product = new Product()
            {
                ProductName = entity.ProductName,
                Price = entity.Price,
                ImageUrl = entity.ImageUrl,
                CategoryId = entity.CategoryId,
            };
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> ProductsEdit(Product product)
        {

            var entity = await _productService.GetById(product.Id);
            entity.ProductName = product.ProductName;
            entity.Price = product.Price;
            entity.ImageUrl = product.ImageUrl;
            entity.CategoryId = product.CategoryId;
            _productService.Update(entity);
            return RedirectToAction("Products");

        }

        public async Task<IActionResult> DeleteProducts(int productId)
        {
            var product = await _productService.GetById(productId);
            if (product != null)
            {
                _productService.Delete(product);
            }
            return RedirectToAction("Products");
        }
    }
}
