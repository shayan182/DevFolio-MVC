using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFolio_MVC.Data;
using DevFolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFolio_MVC.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Blogs = BlogsData.GetBlogs();
            return View("_Blog", Blogs);
        }
    }
}
