using asp.net_mvc_ecommerce_features_labtask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace asp.net_mvc_ecommerce_features_labtask.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult CartIndex()
        {
            var db = new EcommerceDBEntities();
            var productsData = db.Products.ToList();

            return View(productsData);
        }


     /*   [HttpPost]
        public ActionResult CartIndex()*/


        public ActionResult ViewCart()
        {
            return View();
        }
    }
}