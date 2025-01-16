using DemoASPNProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoASPNProject.Controllers
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

        public IActionResult About()
        {
            return View();
        }

        public IActionResult PrintingNumbers(int count = 5)
        {
            ViewBag.Count = count;
            return View();
        }

        public IActionResult FileVisualizer()
        {
            string path = @"C:\";
            var files = Directory
                .GetDirectories(path)
                .ToList();
            files.AddRange(Directory.GetFiles(path));
            return View(files);
        }

        public IActionResult TestAction()
        {
            ViewBag.Message = "This is a test page";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
