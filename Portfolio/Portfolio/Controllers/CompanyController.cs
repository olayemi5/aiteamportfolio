using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult WhyChooseUs()
        {
            return View();
        }
        public IActionResult OurTeam()
        {
            return View();
        }
    }
}
