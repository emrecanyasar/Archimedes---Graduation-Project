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
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }        
    }
}