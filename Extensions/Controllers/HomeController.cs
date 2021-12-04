using Extensions.Infrastructure;
using Extensions.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Extensions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        // Custum Attribute
        [Ignore]
        [LoginFilter]
        public IActionResult Index()
        {
            // Log Created
            _logger.LogInformation("Starting Index...");
            return View();
        }

        public IActionResult Privacy()
        {
            // Log Created
            _logger.LogInformation("Starting Privacy...");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
