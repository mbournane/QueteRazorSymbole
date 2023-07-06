using Microsoft.AspNetCore.Mvc;
using QueteRazorSymbole.Models;
using System.Diagnostics;
using System.Reflection;

namespace QueteRazorSymbole.Controllers
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
            String conclusion = String.Empty;

            IEnumerable<Int32> integers = new Int32[] { 1, 2, 3, 4 };

            Int32 sum = integers.Sum();

            //if (sum > 10000000)

            //{

            //    conclusion = "You earn too much money";

            //}

            //else

            //{

            //    conclusion = "You should ask for a salary raise";

            //}
            return View(sum);
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