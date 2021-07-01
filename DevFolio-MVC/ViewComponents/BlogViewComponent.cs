﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFolio_MVC.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Blogs = new List<Blog>
            {
                new Blog(1,"post-1.jpg","See more ideas about Travel","Travel","Shayan Tohdi","Proin eget tortor risus. Pellentesque in ipsum id orci porta dapibus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi."),
                new Blog(2,"post-2.jpg","who am I ","Personal","Shayan Tohdi","Proin eget tortor risus. Pellentesque in ipsum id orci porta dapibus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi."),
                new Blog(3,"post-3.jpg","best programming language","programming","Shayan Tohdi","Proin eget tortor risus. Pellentesque in ipsum id orci porta dapibus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.")
            };
            return View("_Blog", Blogs);
        }
    }
}
