using Demo01Online.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo01Online.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //BaseUrl/Home/Index
        public IActionResult Index()
        {
            return View();
        }

        //BaseUrl/Home/Privacy

      
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
