using asp.net_mvc_ecommerce_features_labtask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_ecommerce_features_labtask.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult UserIndex()
        {
            {
                var db = new EcommerceDBEntities();
                var userData = db.Users.ToList();

                return View(userData);
            }
        }
        [HttpPost]
        public ActionResult Create(User u)
            
        {
            var db = new EcommerceDBEntities();
            db.Users.Add(u);
            db.SaveChanges();
            return RedirectToAction("UserIndex");   
        }
        [HttpGet]
        public ActionResult Create() 
        {
            return  View();
        }

       

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, int userid)
        {
            using (var db = new EcommerceDBEntities())
            {
                var user = db.Users.FirstOrDefault(u => u.UserName == username && u.UserId == userid);

                if (user != null)
                {
                    // Valid credentials, redirect to Home or a specific page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Invalid credentials, display error message or handle accordingly
                    ViewBag.ErrorMessage = "Invalid username or userid";
                    return View();
                }
            }
        }

    }
}