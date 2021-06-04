using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using aadt.Models;

namespace aadt.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Anon()
        {
            return View();
        }

        [Authorize]
        public IActionResult Authorized()
        {
            return View();
        }

        [Authorize(Roles = "SiteManager")]
        public IActionResult SiteManager()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Admin()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
