using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models_And_Model_Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models_And_Model_Binding.Controllers
{
    public class MovieController : Controller
    {
        [HttpGet] // when user navigates to URL
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost] // call after user submits form data
        public IActionResult Add(IFormCollection form)
        {
            // Need server-side validation for all data
            Movie s = new Movie();
            s.Title = form["movie-title"];
            s.ReleaseYear = form["release-year"];
            s.Genre = form["genre"];
            s.Rating = form["rating"];
            s.Length = form["length"];

            // Add to database
            ViewData["Added"] = s.Title + " was added ";

            return View();
        }

        [HttpGet]
        public IActionResult AddWithBinding()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddWithBinding(Movie s)
        {
            if (ModelState.IsValid) // True if all validation in model passes
            {
                ViewData["Message"] = $"{s.Title} was added";
            }
            return View();
        }
    }
}
