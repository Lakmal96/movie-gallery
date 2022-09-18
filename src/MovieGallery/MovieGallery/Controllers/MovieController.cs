using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieGallery.Models;

namespace MovieGallery.Controllers
{
    public class MovieController : Controller
    {
        public ActionResult Detail()
        {
            var movie = new Movie()
            {
                MovieName = "Zack Snyder's Justice League",
                Director = "Zack Snyder",
                Description = "Bruce Wayne and Diana Prince try to bring the meta humans of Earth together after the death of Clark Kent. Meanwhile, Darkseid sends Steppenwolf to Earth with a vast army to subjugate humans.",
                Cast = new Cast[]
                {
                    new Cast() {ArtistName = "Henry Cavill", Role = "Superman"},
                    new Cast() {ArtistName = "Ben Afflec", Role = "Batman"},
                    new Cast() {ArtistName = "Gal Gadot", Role = "Wonder Woman"},
                    new Cast() {ArtistName = "Jason Mamoa", Role = "Aquaman"},
                    new Cast() {ArtistName = "Ezra Miller", Role = "The Flash"},
                    new Cast() {ArtistName = "Ray Fisher", Role = "Cyborg"}
                }
            };
            
            return View(movie);
        }
    }
}