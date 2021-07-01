using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFolio_MVC.Models
{
    public class Blog
    {
        public Blog(int id, string image, string title, string category, string client, string description)
        {
            Id = id;
            Image = image;
            Title = title;
            Category = category;
            Client = client;
            Description = description;
        }

        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Client { get; set; }
        public string Description { get; set; }
    }
}
