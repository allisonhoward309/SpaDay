using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
         public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            Console.WriteLine(newUser);
            
            //ViewBag.date = newUser.Date;
            if(newUser.Password == verify)
            {
                //ViewBag.name = newUser.Username;
                ViewBag.user = newUser;
                return View("Index");
            } else
            {
                ViewBag.error = "Your passwords do not match!";
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");

            }
            
        }
    }
}
