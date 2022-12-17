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
    //[Authorize]
    public class MemberController : BaseController
    {


        public MemberController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, ICategoryService categoryService, IProductService productService, IShopListService shopListService, IShopListDetailService shopListDetailService, ArchimedeDbContext archimedeDbContext,IUserShopListService userShopListService) : base(userManager, signInManager, categoryService, productService, shopListService, shopListDetailService, archimedeDbContext, userShopListService)
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
            var searchList = _productService.GetSearchResult(search);
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
            _shopListService.Create(entity, userId);

            //shopList.Users = userId.Select(catId => catId == user.Id).FirstOrDefault();
            return RedirectToAction("MyList");
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

        public IActionResult ListDetail(int listId)
        {
            var shopListDetail = _shopListDetailService.GetShopListDetailByListId(listId);
            return View(shopListDetail);
        }

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            var user = HttpContext.User.Identity.Name;
            var userInfo = await _userManager.FindByNameAsync(user);
            var userId = userInfo.Id;
            List<ShopList> shopLists = _shopListService.GetShopListByUser(userId);
            ViewBag.MyShopList = new SelectList(shopLists, "Id", "ShopListName");
            List<Product> products = await _productService.GetAll();
            ViewBag.Product = new SelectList(products, "Id", "ProductName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ShopListDetail shopListDetail)
        {
            var user = HttpContext.User.Identity.Name;
            var userInfo = await _userManager.FindByNameAsync(user);
            var userId = userInfo.Id;
            List<ShopList> shopLists = _shopListService.GetShopListByUser(userId);
            ViewBag.MyShopList = new SelectList(shopLists, "Id", "ShopListName");
            List<Product> products = await _productService.GetAll();
            ViewBag.Product = new SelectList(products, "Id", "ProductName");
            var entity = new ShopListDetail()
            {
                ShopListId = shopListDetail.ShopListId,
                ProductId = shopListDetail.ProductId,
                Quantity = shopListDetail.Quantity,
                UnitPrice = shopListDetail.UnitPrice * shopListDetail.Quantity
            };
            var item = _archimedeDbContext.ShopLists.Find(shopListDetail.ShopListId);
            if (item.Use == false)
            {
                _shopListDetailService.Create(entity);
            }
            else
            {
                ModelState.AddModelError("", "Alışverişe başladığınız listeye ürün ekleyemezsiniz");
            }
            return RedirectToAction("MyList");
        }

        public async Task<IActionResult> DeleteListItem(int itemId)
        {
            var item = await _shopListDetailService.GetById(itemId);
            _shopListDetailService.Delete(item);

            return RedirectToAction("ListDetail");
        }

        public IActionResult Shopping(int id)
        {
            var item = _archimedeDbContext.ShopLists.Find(id);
            if (item.Use == false)
            {
                item.Use = true;
            }
            else
            {
                item.Use = false;
            }
            _archimedeDbContext.SaveChanges();
            return RedirectToAction("MyList");
        }

        [HttpGet]
        public async Task<IActionResult> AllList()
        {
            var user = HttpContext.User.Identity.Name;
            var userInfo = await _userManager.FindByNameAsync(user);
            var userId = userInfo.Id;
            var allList = _userShopListService.AllList(userId);
            
            return View(allList);
        }
        //AddMyLists
        [HttpGet]
        public async Task<IActionResult> AddMyLists()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMyLists(int shopListId, string userId)
        {
            var name = HttpContext.User.Identity.Name;
            var user = await _userManager.FindByNameAsync(name);
            userId = user.Id;
            _userShopListService.Create(userId,shopListId);
            return RedirectToAction("AllList");
        }

    }
}
