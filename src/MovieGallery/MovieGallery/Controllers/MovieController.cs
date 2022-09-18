using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.MovieName = "Zack Snyder's Justice League";
            ViewBag.Director = "Zack Snyder";
            ViewBag.Description = "<p><b>Bruce Wayne</b> and <b>Diana Prince</b> try to bring the meta humans of Earth together after the death of <b>Clark Kent</b>. Meanwhile, <b>Darkseid</b> sends <b>Steppenwolf</b> to Earth with a vast army to subjugate humans.</p>";
            ViewBag.Cast = new string[]
            {
                "Henry Cavill", "Ben Afflec", "Gal Gadot", "Jason Mamoa", "Ezra Miller"
            };
            return View();
        }
    }
}