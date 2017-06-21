using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using logdemo.Models;
using System.Collections.Generic;

namespace logdemo.Controllers
{
    public class UsersController : Controller
    {
        private logdemoContext _context;

        public UsersController(logdemoContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.errors = new List<string>();
            return View("logreg");
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(RegViewModel model)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("YOU GOT TO HERE !!!!!!!");
                User bob = new User
                {
                    name=model.Name,
                    password=model.password
                };
                _context.Peeps.Add(bob);
                return View("success");
            }
            System.Console.WriteLine("Well, we got to this one isntead");
            ViewBag.errors = ModelState.Values;
            return View("logreg");
        }

        [HttpPost]
        
    }
}