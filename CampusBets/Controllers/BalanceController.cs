using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CampusBets.Controllers
{
    public class BalanceController : Controller
    {
        // GET: Balance
        public ActionResult Balance()
        {
            ViewBag.Message = "Your account balance";

        //adaugat cod de adaugare bani in cont ( variabila accBalance din IdentityModel trebuie actualiazata cu suma adaugata in cont)
            return View();
        }
    }
}