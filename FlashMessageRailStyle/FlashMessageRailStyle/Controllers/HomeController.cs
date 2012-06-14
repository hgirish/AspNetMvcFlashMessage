using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlashMessageRailStyle.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
          
            return View();
        }

        public ActionResult Info()
        {
          TempData["info"] = "INFO flash message";
          return RedirectToAction("Index");
        }
        public ActionResult Warning()
        {
        // warning will be displayed as warning has a priority over info
          TempData["info"] = "INFO flash message";
          TempData["warning"] = "WARNING flash message";
          return RedirectToAction("Index");
        }
        public ActionResult Error()
        {
        // error will be displayed as error has a highest priority
          TempData["info"] = "INFO flash message";
          TempData["warning"] = "WARNING flash message";
          TempData["error"] = "ERROR flash message";
          return RedirectToAction("Index");
        }
        

    }
}
