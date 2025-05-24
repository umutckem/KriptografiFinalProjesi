using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using KriptografiFinalProjesi.Helpers;
using KriptografiFinalProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace KriptografiFinalProjesi.Controllers
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
    }
}
