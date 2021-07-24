using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models_And_Model_Binding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models_And_Model_Binding.Controllers
{
    public class StudentController : Controller
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
            Student s = new Student();
            s.FullName = form["full-name"];
            s.DateOfBirth = Convert.ToDateTime(form["date-of-birth"]);
            s.Email = form["email"];
            s.Phone = form["phone-number"];

            // Add to database
            ViewData["Added"] = s.FullName + " was added with an ID of 1";

            return View();
        }
    }
}
