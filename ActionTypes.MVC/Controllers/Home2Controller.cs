using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionTypes.MVC.Controllers
{
    public class Home2Controller : Controller
    {
        //PartialViewResult
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        //birinci yol
        public ActionResult GetirKategorilerPartial()
        {
            return PartialView("_KategorilerPartial");
        }

        //ikinci yol
        public ActionResult GetirKategorilerPartial2()
        {
                List<string> kategoriler = new List<string>()
    {
        "Teknoloji",
        "Araçlar",
        "Temizlik",
        "Gıda",
        "Giyim"
    };
            
            return PartialView("_KategorilerPartial2",kategoriler);
        }
    }
}