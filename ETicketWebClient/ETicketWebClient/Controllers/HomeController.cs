using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;


namespace ETicketWebClient.Controllers
{
    public class HomeController : Controller
    {
        ETicketService.EventServiceClient eventClient = new ETicketService.EventServiceClient();
        public ActionResult Index(int? i)
        {
            var events = eventClient.GetAllEvents();
            return View(events.ToList().ToPagedList(i ?? 1, 4));
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
    }
}