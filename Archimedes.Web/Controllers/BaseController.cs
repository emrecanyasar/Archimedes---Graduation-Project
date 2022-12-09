using Archimedes.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Archimedes.Web.Controllers
{
    public class BaseController : Controller
    {
        public UserManager<AppUser> _userManager { get; }

        public void AddModelError(IdentityResult result)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
        }
    }
}
