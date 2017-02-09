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

        [Route("Cards")]
        public IActionResult Cards()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("FAQ")]
        public IActionResult FAQ()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Live_Scan")]
        public IActionResult Live_Scan()
        {
            return View();
        }

        [Route("Ink_Fingerprinting")]
        public IActionResult Ink_Fingerprinting()
        {
            return View();
        }

        [Route("NY_State_Requirements")]
        public IActionResult NY_State_Requirements()
        {
            return View();
        }

        [Route("NMLS_Requirements")]
        public IActionResult NMLS_Requirements()
        {
            return View();
        }

        [Route("TWIC")]
        public IActionResult TWIC()
        {
            return View();
        }

        [Route("FINRA_Channeling")]
        public IActionResult FINRA_Channeling()
        {
            return View();
        }

        [Route("FBI_Channeling")]
        public IActionResult FBI_Channeling()
        {
            return View();
        }

        [Route("Fingerprint_Archiving")]
        public IActionResult Fingerprint_Archiving()
        {
            return View();
        }

        [Route("Notary_Service")]
        public IActionResult Notary_Service()
        {
            return View();
        }

        [Route("Mobile_Fingerprints")]
        public IActionResult Mobile_Fingerprints()
        {
            return View();
        }
    }
}
