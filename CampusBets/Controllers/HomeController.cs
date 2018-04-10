using CampusBets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusBets.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            return RedirectToAction("Login", "Account");
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

        public ActionResult EventList()
        {
            //trebuie luata din baza de date lista de evenimente si trimisa 
            //catre view ( doar evenimentele cu data mai mare ca data curenta a sistemului)


            //var allEvents = Events.toList();
            //var model = new List<Events>();

            //return View(model);
            return View();
        }

        public ActionResult MyTicket()
        {
            ViewBag.Message = "MyTicket";

            return View();
        }
    }
}