using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Validation.Models;

namespace Validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Success(Car c)
        {
            return View();
        }

        public ActionResult Car(Car c)
        {
            List<string> AcceptibleMakes = new List<string>() { "toyota", "ford", "volkswagon" };
            List<string> AcceptibleColors = new List<string>() { "red", "white", "blue"};
            bool goodMake = AcceptibleMakes.Contains(c.Make.ToLower());
            bool goodColor = AcceptibleColors.Contains(c.Color.ToLower());
            
            if (goodMake && goodColor)
            {
                return View(c);
            }
            else
            {
                return RedirectToAction("Error");
            }
        }
     
    }
}