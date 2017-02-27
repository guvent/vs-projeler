using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.InteropServices;
using System.IO;

namespace girisyap.Controllers
{
    public class Kullanicilar
    {
        [DllImport("kripto.dll")]
        private static extern string k_sifrele(char[] VERI);

        [DllImport("kripto.dll")]
        private static extern string k_sifrecoz(char[] VERI);

        [DllImport("kripto.dll")]
        private static extern int k_denetle(char[] veri1, char[] veri2);
        
        //--------------------------------------

        private char[] k = { 'd', 'e', 'n', 'e', 'm', 'e', '\0' };
        private char[] s = { '1', '0', '2', '0', '3', '0', '\0' };

        public char[] etiket;

        public HttpCookie girisyap(char[] kullanici,char[] sifre)
        {
            int ksonuc = 1, ssonuc = 1;

            string jt = "";
            char[] jv = new char[1024];

            int i = 0;

            if (k[i] != '\0' && kullanici[i] != '\0')
            {
                while (k[i] != '\0' && kullanici[i] != '\0')
                {
                    if (kullanici[i] != k[i]) { ksonuc = 0; break; }
                    //else { ksonuc = 1; }

                    i++;
                }
                if (kullanici[i] != k[i]) { ksonuc = 0; }
                   
            }
            else { 
                ksonuc = 0; }

            i = 0;

            if (s[i] != '\0' && sifre[i] != '\0')
            {
                while (s[i] != '\0' && sifre[i] != '\0')
                {
                    if (sifre[i] != s[i]) { ssonuc = 0; break; }
                    //else { ssonuc = 1; }

                    i++;
                }
                if (sifre[i] != s[i]) { ssonuc = 0;  }
            }
            else { 
                ssonuc = 0; }

            HttpCookie ck = null;

            if (ksonuc == 1 && ssonuc == 1) 
            {
                jv = birlestir(kullanici, sifre);

                jt = jeton(jv);

                /* cerez muhabbeti :D */

                ck = new HttpCookie(kullanici.ToString());
                ck.Value = jt;
                ck.Expires = DateTime.Now.AddHours(1);
                

                etiket = kullanici;
                
            }

            return ck;
        }

        public bool misafir(HttpRequestBase hrq)
        {
            bool m = true;

            string jt = "";
            char[] jv = new char[1024];

            HttpCookie misafircips = hrq.Cookies.Get(k.ToString());
            if (misafircips != null)
            {
                jt = misafircips.Value;

                if (denetle(birlestir(k, s), jt.ToCharArray()))
                { m = false; }
            }
            return m;
        }

        public bool cikisyap(HttpResponseBase hrq)
        {

            HttpCookie cikiscips = new HttpCookie(k.ToString());
            cikiscips.Expires = DateTime.Now.AddHours(-1);

            hrq.Cookies.Add(cikiscips);

            return true;
        }

        private string jeton(char[] veri)
        {
            string j = "";

            j = k_sifrele(veri);

            return j;
        }

        private bool denetle(char[] veri1, char[] veri2) // veri2 etiket 
        {
            bool sonuc = false;

            if (k_denetle(veri1, veri2) != 1)
            { sonuc = true; }
            
            return sonuc;
        }

        private char[] birlestir(char[] a, char[] b)
        {
            char[] r = new char[1024];
            
            int i = 0, j = 0;

            while(a[i] != '\0')
            {
                r[i] = a[i];
                i++;
            }

            while(b[j] != '\0')
            {
                r[i] = b[j];
                i++; j++;
            }

            return r;
        }

       

    }
}