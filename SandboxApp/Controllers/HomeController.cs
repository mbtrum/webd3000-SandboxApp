using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SandboxApp.Models;

namespace SandboxApp.Controllers
{
    public class HomeController : Controller
    {
        // constructor
        public HomeController()
        {            
        }

        public IActionResult Unauth()
        {
            bool isLoggedIn = true;

            if (isLoggedIn)
            {
                return View();
            }
            else
            {
                return new UnauthorizedResult();
            }                
        }

        public JsonResult Json()
        {
            return Json(new List<string> { "Wow,", "this", "is", "crazy!" });
        }

        public ContentResult PlainText()
        {
            return Content("Hello, this is plain text!");
        }


        public IActionResult Index()
        {
            return View();
        }               

        public ViewResult Privacy()
        {
            return View();
        }

        public IActionResult Pikachu()
        {
            return View();
        }

        public IActionResult Ditto()
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
