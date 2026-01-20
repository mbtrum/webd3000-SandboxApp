using Microsoft.AspNetCore.Mvc;
using SandboxApp.Models;

namespace SandboxApp.Controllers
{
    // This controller is to play around with HTML forms.
    public class FormsController : Controller
    {
        // GET request
        public IActionResult ContactForm()
        {
            return View();
        }

        // Example 1

        // POST request
        //[HttpPost]
        //public IActionResult ContactForm(string FirstName, string LastName)
        //{
        //    string message = $"Welcome to my web app {FirstName} {LastName}.";

        //    ViewData["Message"] = message;

        //    return View();
        //}

        // Example 2

        [HttpPost]
        public IActionResult ContactForm(Person person)
        {
            string message = $"Welcome to my web app {person.FirstName} {person.LastName}.";

            ViewData["Message"] = message;

            return View();
        }

        // Example 3
        // [Bind] explicitly binds the inputs
        //[HttpPost]
        //public IActionResult ContactForm([Bind("FirstName,LastName")] Person person)
        //{
        //    string message = $"Welcome to my web app {person.FirstName} {person.LastName}.";

        //    ViewData["Message"] = message;

        //    return View();
        //}
    }
}
