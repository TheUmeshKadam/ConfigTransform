using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConfigTransform.Models;
using Microsoft.Extensions.Options;

namespace ConfigTransform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IOptions<ValueObjects.AppSettings> _config;

        public HomeController(ILogger<HomeController> logger, IOptions<ValueObjects.AppSettings> config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View(_config.Value);
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
