using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NewYorkFingerPrints.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Services")]
        public IActionResult Services()
        {
            return View();
        }

        [Route("Businesses")]
        public IActionResult Businesses()
        {
            return View();
        }

        [Route("Individuals")]
        public IActionResult Individuals()
        {
            return View();
        }
    }
}
