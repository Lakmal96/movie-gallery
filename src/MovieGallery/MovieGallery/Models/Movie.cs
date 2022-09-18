using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieGallery.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public Cast[] Cast { get; set; }
    }
}