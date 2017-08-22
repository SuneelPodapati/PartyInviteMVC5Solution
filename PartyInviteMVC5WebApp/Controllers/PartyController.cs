using PartyInviteMVC5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInviteMVC5WebApp.Controllers
{
    public class PartyController : Controller
    {
        #region Default
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greet = hour < 16 ? "Good Afternoon " + DateTime.Now : "Good Evening " + DateTime.Now;

            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            ViewBag.RouteDetails = string.Format("{0}:: {1} --- {2}", controller, action, id);

            return View();
        }

        public ViewResult RSVPForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (string.IsNullOrEmpty(guestResponse.LastName))
            {
                ModelState.AddModelError(string.Empty, "From ME Last Name cannot be Empty or null");
            }

            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            return View();
        }

        #endregion
        public ContentResult ContentList()
        {
            var result = "<div style='background-color:cornflowerblue; text-align:center; Color: White;'><h1>This is a ContentResult</h1></div>";
            return Content(result);
        }

        public JsonResult List()
        {
            var result = Json(new { Name = "Phantom", Email = "phantom@p.com", Mobile = "1212121" });
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public string Greeting()
        {
            return string.Format("From {0} Controller and {1} Action", "Party", "Greeting");
        }


    }
}