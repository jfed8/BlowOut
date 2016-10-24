using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
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

        public ActionResult Rentals()
        {
            return View();
        }

        public ActionResult Instrument(string inst)
        {
            ViewBag.Instrument = inst;

            switch(inst)
            {
                case "Trumpet":
                    ViewBag.New = "$55";
                    ViewBag.Used = "$25";
                    ViewBag.Img = "../img/trumpet.jpg";
                    break;
                case "Trombone":
                    ViewBag.New = "$60";
                    ViewBag.Used = "$35";
                    ViewBag.Img = "../img/trombone.jpg";
                    break;
                case "French Horn":
                    ViewBag.New = "$70";
                    ViewBag.Used = "$50";
                    ViewBag.Img = "../img/frenchhorn.jpg";
                    break;
                case "Flute":
                    ViewBag.New = "$40";
                    ViewBag.Used = "$25";
                    ViewBag.Img = "../img/Flute.jpg";
                    break;
                case "Clarinet":
                    ViewBag.New = "$35";
                    ViewBag.Used = "$27";
                    ViewBag.Img = "../img/clarinet.jpg";
                    break;
                case "Saxophone":
                    ViewBag.New = "$42";
                    ViewBag.Used = "$30";
                    ViewBag.Img = "../img/altosaxophonebutton.jpg";
                    break;
                default:
                    ViewBag.New = "FREE";
                    ViewBag.Used = "FREE";
                    break;
                            
            }

            if (inst == null)
            {
                return RedirectToAction("Rentals");
            }

            return View();
        }
    }
}