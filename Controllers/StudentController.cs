using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models_And_Model_Binding.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
