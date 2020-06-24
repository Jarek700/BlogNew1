using BlogNew1.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BlogNew1.Models
{
    public class HomeController : Controller
    {
        // GET: Home
        private ArtykulyContext db = new ArtykulyContext();
        public ActionResult Index()
        {

            return View(db.Artykuly.ToList());

        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Artykuly artykuly = db.Artykuly.Find(id);
            if (artykuly == null)
            {
                return HttpNotFound();
            }
            return View(artykuly);
        }
    }
}