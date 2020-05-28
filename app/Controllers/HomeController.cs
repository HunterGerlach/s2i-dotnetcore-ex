using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using Microsoft.Extensions.Logging;

namespace app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
	    
	public HomeController( ILogger<HomeController> logger)
        {
		_logger = logger;
	}

	public IActionResult Index()
        {
	    _logger.LogInformation( "Accessing: INDEX" );
            return View();
        }

        public IActionResult Privacy()
        {
	    _logger.LogInformation( "Accessing: PRIVACY" );
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
