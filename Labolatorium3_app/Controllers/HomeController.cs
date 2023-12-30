using Labolatorium3_app.Middlewares;
using Labolatorium3_app.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labolatorium3_app.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewData["Visit"] = Response.HttpContext.Items[LastVisitCookie.CookieName];
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}