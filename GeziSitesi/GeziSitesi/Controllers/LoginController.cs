using GeziSitesi.Models.Classlar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace GeziSitesi.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db=new Context();
        public ActionResult Index()
        {
            return View();
        }

       


        public ActionResult Giris()
        {
            return View();
        }



        // kullanıcı giris kısmı 
        [HttpPost]
        public ActionResult Giris(Admin aut)
        {
            var kullanıcı = db.Admins.First(x => x.kullaniciadi == aut.kullaniciadi && x.sifre == aut.sifre);
            if (kullanıcı != null)
            {
                FormsAuthentication.SetAuthCookie(kullanıcı.kullaniciadi, false);
                Session["kullaniciadi"] = kullanıcı.kullaniciadi.ToString();
                return RedirectToAction("Index", "Admin");

            }
            else
            {
                return RedirectToAction("Login","Giris");
            }
           
        }



        // çıkış işlemi 
        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Giris", "Login");
        }




        
       
      
    }
}