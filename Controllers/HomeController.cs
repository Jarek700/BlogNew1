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
            ArtykulyContext db = new ArtykulyContext();
            var artykul = db.Artykuly;
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


        //-------- Dostęp do bazy przy urzciu ADO.NET - bezpośrednie zapytania do bazy danych
        //string ArtykulyConnectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ArtykulyConnectionString; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False";

        //string query = "Select Tytul, TekstArtykulu from dbo.Artykulies where id = @id";

        //int id = 2;

        //using (SqlConnection connection = new SqlConnection(ArtykulyConnectionString))
        //{
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@id", id);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();

        //    reader.Read();

        //    var Tytul = reader[0];
        //    var TekstArtykulu = reader[1];

        //    ViewBag.Tytul = Tytul;
        //    ViewBag.TekstArtykulu = TekstArtykulu;
        //}
    }
}