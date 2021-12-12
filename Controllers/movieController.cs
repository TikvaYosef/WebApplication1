using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class movieController : Controller
    {
        // GET: movie
        public ActionResult Index()
        {
            ViewBag.Title = "movies";

            ViewBag.Message = "Your application description page.";
           

            return View();
        }

        public ActionResult Movie()
        {
            string[] movies = new string[] { "shrek", "big mama","big mama2","norbit" };
            ViewBag.ListOfMovies = movies;
          

            return View();
        }
    }
}