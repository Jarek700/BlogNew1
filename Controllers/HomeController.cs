using BlogNew1.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogNew1.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        
        public ActionResult Index()
        {

            return View();

        }
       // [Authorize(Roles ="Admin")]                   //autoryzacja na później
        [HttpPost]
        public ActionResult DodajArtykul(Artykuly artykuly)
        {
            //if (!ModelState.IsValid)                        // walidacja z negacją
            //    return View("DodajArtykul", artykuly);
            //else
            {
                ArtykulyContext db = new ArtykulyContext();
                db.Artykuly.Add(artykuly);
                db.SaveChanges();
                return View("DodajArtykul");
            }
        }
        [HttpGet]
        public ActionResult DodajArtykul()
        {
                return View();
        }
    }
}