using Microsoft.AspNetCore.Mvc;
using NetCoreLearningPath.Carnation.Web.Models;
using System.Diagnostics;

namespace NetCoreLearningPath.Carnation.Web.Controllers
{
    //First Controller changed Again Satyam
    //First Controller changed Again Satyam
    //First Controller changed Again Satyam11
    //First Controller changed Again siddarth
    //First Controller changed Again Satyam11
    //First Controller changed Again Satyam11
    //First Controller changed Again Satyam11

    //Cherry Pick1
    //Cherry Pick2


    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexTest()
        {
            return View();
        }

        public IActionResult IndexTest1()
        {
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
