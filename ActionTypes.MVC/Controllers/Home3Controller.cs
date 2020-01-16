using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionTypes.MVC.Controllers
{
    public class Home3Controller : Controller
    {
        //JavascriptResult

        // GET: Home3
        public ActionResult Index()
        {
            return View();
        }
        public JavaScriptResult BaslangicMesaji()
        {
            string js = "alert('Merhaba JsResult')";
            return JavaScript(js);
        }

        public JavaScriptResult JsButtonClick()
        {
            string js = "function button_click(){alert('Merhaba JsResult');}";
            return JavaScript(js);
        }
    }
}