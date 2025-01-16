using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoASPNProject.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: CalculatorController
        public IActionResult Index()
        {
            return View("Index"); //imeto na view Index.cshtml
        }

        public IActionResult Index(CalculatorController calculator)
        {
            return View("Index"); //imeto na view Index.cshtml
        }
    }
}
