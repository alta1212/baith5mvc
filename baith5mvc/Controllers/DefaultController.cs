using baith5mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baith5mvc.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        svmodel sv = new svmodel();
        public ActionResult Index()
        {
          List<sv> listsv=  sv.getsv();
            return View(listsv);
        }
    }
}