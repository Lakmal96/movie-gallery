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
            ViewBag.Description = "Bruce Wayne and Diana Prince try to bring the meta humans of Earth together after the death of Clark Kent. Meanwhile, Darkseid sends Steppenwolf to Earth with a vast army to subjugate humans.";
            ViewBag.Cast = new string[]
            {
                "Superman: Henry Cavill", "Batman: Ben Afflec", "Wonder Women: Gal Gadot", "Aquaman: Jason Mamoa", "The Flash: Ezra Miller"
            };
            return View();
        }
    }
}