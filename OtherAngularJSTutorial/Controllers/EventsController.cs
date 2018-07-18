using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OtherAngularJSTutorial.Controllers
{
    public class EventsController : Controller
    {
        public ActionResult Home()
        {
            ViewBag.Message = "Events view page.";

            return View();
        }
    }
}