using Archimedes.Business.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using Archimedes.Web.Controllers;
using Archimedes.Web.Models;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArchimedesUI.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService,IShopListService shopListService) : base(userManager, signInManager, categoryService, productService,shopListService)
        {

        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();

            return View(products);
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