using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogNew1.Controllers
{
    public class ZegarekController : Controller
    {
        // GET: Zegarek
        [ChildActionOnly]
        public ActionResult PokazGodzine()
        {
            var czas = DateTime.Now.ToLongTimeString();
            return PartialView("PartialCzas", czas);
        }

        [ChildActionOnly]
        public String PokazGodzine2()
        {
            return DateTime.Now.ToLongTimeString();
            
        }
    }
}