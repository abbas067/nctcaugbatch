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
        private readonly IEmployee context;
        public HomeController(ILogger<HomeController> logger, IEmployee _context)
        {
            _logger = logger;
            context = _context;
        }

        public IActionResult Index()
        {
            var model = context.GetEmployeeList();
            return View(model);
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
