using Archimedes.Business.Abstract;
using Archimedes.Data.Concrete.EfCore;
using Archimedes.Entity;
using Archimedes.Web.Controllers;
using Archimedes.Web.Models;
using Archimedes.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArchimedesUI.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService) : base(userManager, signInManager, categoryService, productService)
        {

        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();

            return View(products);
        }        
    }
}