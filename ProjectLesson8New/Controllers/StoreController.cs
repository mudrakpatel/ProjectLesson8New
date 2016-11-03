using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectLesson8New.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            ViewBag.Message = "ViewBag message is here";
            return View();
        }

        //GET: Store/Browse?genre=Electronic
        public ActionResult Browse(string genre)
        {
             ViewBag.Message = HttpUtility.HtmlEncode("Store.Browse, Genre= " + genre);
            return View();
        }

        //GET: Store/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Message = HttpUtility.HtmlEncode("Store.Details, ID= " + id);
            return View();
        }
    }
}