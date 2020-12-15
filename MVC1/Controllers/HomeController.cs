using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       
        [HttpGet("")]
        public IActionResult Index()
        {
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
          
            return View(someUser);
            
        }

        [HttpGet("string")]
        public IActionResult String()
        {
            string[] names= new string[]
            {
                "devin",
                "christy",
                "patrick",
                "sebastian"
            };

            return View(names);

        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User devin = new User
            {
                FirstName = "devin",
                LastName = "castro"
            };

            return View(devin);

        }

        [HttpGet("users")]
        public IActionResult Users()
        {
            User devin = new User
            {
                FirstName = "devin",
                LastName = "castro"
            };

            User christy = new User
            {
                FirstName = "Christy",
                LastName = "Hanamure"
            };

            User patrick= new User
            {
                FirstName = "Patrick",
                LastName = "Bates"
            };

            List<User> users = new List<User>
            {
                devin, christy, patrick
            };

            return View(users);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
