using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Runtime.InteropServices;
using System.Text;

namespace girisyap.Controllers
{
    
    
    public class HomeController : Controller
    {

        Kullanicilar kullanici = new Kullanicilar();    
        
        //
        // GET: /Home/

        public ActionResult Index()
        {
           
            ViewBag.Title = "Giriş Yap";



            
            return View();
        }

        [HttpPost]
        public ActionResult Index(girisyapform girisveri)
        {
           // ViewBag.okundu = girisveri.ka + " : " + girisveri.sf;

            HttpCookie ck = kullanici.girisyap((girisveri.ka + '\0').ToCharArray(), (girisveri.sf + '\0').ToCharArray());

            if (ck != null)
            {
                Response.Cookies.Add(ck);

                ViewBag.Deneme = "Giriş Başarılı..";
                /* giriş başarılı... */
            }
            else
            {
                Response.Cookies.Remove("");

                ViewBag.Deneme = "Giriş Olmadı.!";
                /* giriş sorunu ..!  */
            }
           

            return View();
        }




    }

    public class girisyapform
    {
        public string ka { get; set; }
        public string sf { get; set; }
    }
}
