using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult UserName()
        {
            ViewBag.Message = "Tikva";
            return View();
        }
        public ActionResult user1()
        {
            ViewBag.UserObject = new { firstName = "Tikva",lastName = "Yosef",age = 25 };
            //ViewBag.ObjectOfUsers = UserObject;
            return View();
        }
        public ActionResult NamesOfUsers()
        {
            string[] namesOfUsers = new string[] {"Tikva","Yafit","Eden","Keren","Yosef"};
            ViewBag.ListOfUsers = namesOfUsers;
            return View();
        }
         public ActionResult users()
        {
            return View();
        } 
    }
}