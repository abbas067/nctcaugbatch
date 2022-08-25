using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using nctcaugbatch.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace nctcaugbatch.Controllers
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
            int a = 5;
            int b = 6;

            int sum = a + b;
                ViewBag.sum = sum;

            return View();
        }
        public JsonResult Sum(string Number1, string Number2)
        {

            
                int sum1 = Int32.Parse(Number1) + Int32.Parse(Number2);

            return Json(sum1);
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
