using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace girisyap.Controllers
{
    public class UyeController : Controller
    {
        //
        // GET: /Uye/


        Kullanicilar kullanici = new Kullanicilar();

        public ActionResult banaozel()
        {

            if (kullanici.misafir(this.Request))
            {
                ViewBag.Mesaj = "Giriş Yapmadın.!";
            }
            else
            {
                ViewBag.Mesaj = "Tanıdım Seni :D";
                ViewBag.link = "e";
            }



            return View();

        }
        public ActionResult cikisyap()
        {

            kullanici.cikisyap(this.Response);

            Response.Redirect("/");

            return View();
        }
    }
}
