using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFolio_MVC.Data;
using DevFolio_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFolio_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
    
        public IViewComponentResult Invoke()
        {
            var projects =  ProjectsData.GetProjects();

            return View("_Projects", projects);
        }
    }
}
