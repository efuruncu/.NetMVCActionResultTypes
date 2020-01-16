using ActionTypes.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionTypes.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //ActionResult ilgili sayfaya bizi yönlendirir. Diğer Result türleri ActionResult tan türemiştir.
            return View();
        }
       
        public RedirectResult Index2()
        {
           // return RedirectToAction("Index2");
            return Redirect("/Home/Index"); //Url belirtmemiz lazım
        }
        public ActionResult Index3()
        {
            return View();
        }
        public JsonResult Index4()  
        {
            Urun urun = new Urun();
            urun.ID = 5;
            urun.Adi = "Domates";
            urun.Fiyat = 12000;
            urun.Aciklama = "Bu bir deneme ürünüdür.";

            /*Json result
             * {ID:5,
             * Adi:"Domates",
             * Fiyat:12000,
             * Aciklama="Bu bir deneme ürünüdür."}
             * 
             * Xml result
             * <Urun>
             * <ID>5</ID>
             * <Adi>Domates</Adi>
             * <Fiyat>12000</Fiyat>
             * <Aciklama>Bu bir deneme ürünüdür.</Aciklama>
             * </Urun>
             */
            return Json(urun,JsonRequestBehavior.AllowGet);
        }
        static List<string> Veriler = new List<string>();
        public ActionResult Index5()
        {
            ViewBag.Liste = Veriler;
            return View();
        }
        [HttpPost]
        public ActionResult Index5(string ad, string soyad)
        {
            Veriler.Add(ad + " " + soyad);

            ///Home/Index5?kod=b493c4cc-b973-4064-bf63-ee3ab8783f18
            ///her posttta yeni bir guid oluşturur
            return new RedirectToRouteResult(
                new System.Web.Routing.RouteValueDictionary(
               new
               {
                   action ="Index5",
                   controller="Home",
                   kod=Guid.NewGuid().ToString()
               }
                ));
        }
        

        // FileResult  -  FileStreamResult
        // Dosya döndürme işlemleri
        public ActionResult Index6()
        {
            return View();
        }

        public FileResult PdfDosyaIndir()
        {//MIME Types List
            string dosyaYolu = Server.MapPath("~/Files/FuzzyCognitive.pdf");

            //
            return new FilePathResult(dosyaYolu, "application/pdf");
        }

      
    }
}