using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFolio_MVC.Models
{
    public class Project
    {
        public Project(int id, string image, string title, string category, string client, string date, string url, string description)
        {
            Id = id;
            Image = image;
            Title = title;
            Category = category;
            Client = client;
            Date = date;
            Url = url;
            Description = description;
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public string Date { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }


    }
}
