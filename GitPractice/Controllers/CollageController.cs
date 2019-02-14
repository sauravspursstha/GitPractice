using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitPractice.Controllers
{
    public class CollageController : Controller
    {
        // GET: Collage
        public ActionResult Index()
        {
            return View();
        }
    }
}