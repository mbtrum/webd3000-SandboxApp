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

        // GET - /home/displayphoto
        public IActionResult DisplayPhoto()
        {
            // write code to create a Photo object and pass into the view

            // Create a photo object
            Photo photo = new Photo();

            // Add values to the object's properties
            photo.Id = 1;
            photo.Title = "My cat Penny";
            photo.Description = "Penny is a cuddly Calico cat. She loves to go outside an play.";
            photo.ImageFilename = "cat.jpg";
            photo.CreatedDate = DateTime.Now;

            // Pass the photo object into the view
            return View(photo);
        }

        // GET - /home/displayallphotos
        public IActionResult DisplayAllPhotos()
        {
            // Create a list of photo objects List<Photo>
            List<Photo> photos = new List<Photo>();

            Photo photo1 = new Photo();
            photo1.Id = 1;
            photo1.Title = "My cat Penny";
            photo1.Description = "Penny is a cuddly Calico cat. She loves to go outside an play.";
            photo1.ImageFilename = "cat.jpg";
            photo1.CreatedDate = DateTime.Now;

            Photo photo2 = new Photo();
            photo2.Id = 2;
            photo2.Title = "My dog Audrey";
            photo2.Description = "Audrey is a pug. She loves to eat and sleep.";
            photo2.ImageFilename = "dog.jpg"; 
            photo2.CreatedDate = DateTime.Now;

            //... add a third

            // Add photo objects to the list
            photos.Add(photo1);
            photos.Add(photo2);

            // Pass photos list into the view
            return View(photos); 
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
