using DevFolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
          public IActionResult BlogDetails(int id)
          {
              var Blog = BlogsData.GetBlogBy(id);
              return View(Blog);
          }
    }
}
