using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Store.Data;
using Store.Models;

namespace Store.Controllers
{
    public class ItemsListController : Controller {

        public IActionResult Index()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var Items = db.ItemsList;
            if (Items != null) { ViewData["ItemsList"] = Items; }
        

            var currentUser = db.Users.Where(k => k.Email == User.Identity.Name).FirstOrDefault();
            ViewBag.UserId = currentUser;


            
            return View();

        }


        


        public static void  Test() { }

        








    }
}
