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
    }
}