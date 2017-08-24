using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sidekick.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToDo()
        {
            return View();
        }

        public ActionResult Dictionary()
        {
            return View();
        }

        public ActionResult FlashCards()
        {
            return View();
        }

        //"Other Tasks" will go here, need to see how I'll organize and structure it

        public ActionResult Procrastinate()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}