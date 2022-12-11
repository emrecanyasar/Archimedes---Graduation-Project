using Microsoft.AspNetCore.Mvc;

namespace Archimedes.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
