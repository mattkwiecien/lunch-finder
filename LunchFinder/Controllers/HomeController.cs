using System.Diagnostics;
using LunchFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace LunchFinder.Controllers {
    public class HomeController : Controller {
        
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index() {
            return View();
        }

        [Route("Home/About")]
        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("Home/Contact")]
        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        [Route("Home/Error")]
        public IActionResult Error() {
            return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
