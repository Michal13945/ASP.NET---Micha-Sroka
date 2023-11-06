using Labolatorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Labolatorium_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Calculator([FromQuery(Name = "operator")] string op, double? a,double? b)
        {
            ViewBag.Op="";

            switch (op)
            {
                case "add":
                    ViewBag.Op = a + b;
                    break;

                case "sub":
                    ViewBag.Op = a - b;
                    break;

                case "mul":
                    ViewBag.Op = a * b;
                    break;

                case "div":
                    if(b == 0)
                    {
                        ViewBag.result = "Nie można dzielić przez 0!";
                    }
                    else
                    {
                        ViewBag.Op = a / b;
                    }
                    
                    break;

                default:
                    ViewBag.Op = "Podałeś zły operator !";
                    break;
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}