using Day5.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day5.Controllers
{
    public class EventsController : Controller
    {
        EventsRepository eventsRepository = new EventsRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetTalkDetails()
        {
            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(eventsRepository.GetTalks(), settings),
                ContentType = "application/json"
            };
            return jsonResult;
        }
    }

}