using BarberApp_Manager.Domain.Cabeleireiro;
using BarberApp_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BarberApp_Manager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICabeleireiroDomain _cabeleireiroDomain;

        public HomeController(ILogger<HomeController> logger, ICabeleireiroDomain cabeleireiroDomain)
        {
            _logger = logger;
            _cabeleireiroDomain = cabeleireiroDomain;
        }

        public IActionResult Index()
        {
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