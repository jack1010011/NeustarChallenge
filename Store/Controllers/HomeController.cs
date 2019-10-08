using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Store.Data;

namespace Store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var currentUser = db.Users.Where(k => k.Email == User.Identity.Name).FirstOrDefault();
            ViewBag.UserId = currentUser;
            if (currentUser != null)
            {
            }


            return View();
        }
        //[Authorize]
        //The [Authorize] feature is a permission validation where the user must be logged in the website in order to be able to access it
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
