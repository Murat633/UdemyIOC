using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UdemyIOC.Web.Models;

namespace UdemyIOC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientDateService _transientDateService;

        public HomeController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService)
        {
            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = transientDateService.GetDateTime.TimeOfDay.ToString();
            return View();
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
