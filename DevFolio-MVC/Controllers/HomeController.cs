using DevFolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using DevFolio_MVC.Data;

namespace DevFolio_MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new Message();
            return View(model);
        }
        [HttpPost]
          public IActionResult Index(Message form)
          {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "The information entered is incorrect ! please try again.";
                return View(form);
            }
            ModelState.Clear();
            ViewBag.Success = "Your message was sent successfully!";
            return View();
          }

          public IActionResult ProjectDetails(int id)
          {
              var project = ProjectsData.GetProjectBy(id);
              return View(project);
          }
         [HttpGet]
          public IActionResult BlogDetails(int id)
          {
            // i Implementation validation for form in blogDetails but i need to send two model in view and I do not know how to do it
            var comment = new Comment(); // pass this variable to validation form Of course you must be comment blog details in BlogDetails.cshtml and two more oncomment
            var blog = BlogsData.GetBlogBy(id);
              return View(blog);
          }
          [HttpPost]
          public IActionResult BlogDetails(Comment form)
          {
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "The information entered is incorrect ! please try again.";
               // return View(form);
            }
            ModelState.Clear();
            ViewBag.Success = "Your message was sent successfully!";
            return View();
        }
    }
}
