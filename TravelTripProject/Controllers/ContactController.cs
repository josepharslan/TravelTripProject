using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Iletisim ilt)
        {
            c.Iletisims.Add(ilt);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}