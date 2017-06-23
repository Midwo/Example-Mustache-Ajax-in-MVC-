using ExampleMustache_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleMustache_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MessageModel yourMessage)
        {
            //return content - ajax

            //return Content(string.Format("nick: {0}, content: {1}, date: {2}", yourMessage.Nick, yourMessage.Contents, yourMessage.Date));



            //return json
            return Json(yourMessage);
        }

       
    }
}