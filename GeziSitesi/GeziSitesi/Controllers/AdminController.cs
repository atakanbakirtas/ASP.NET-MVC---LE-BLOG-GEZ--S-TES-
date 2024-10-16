using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using GeziSitesi.Models.Classlar;
using Context = GeziSitesi.Models.Classlar.Context;
namespace GeziSitesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

       
        Context c=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var değer=c.Blogs.ToList();
            return View(değer);
        }



        // blog silme kısmı 
        [Authorize]
        public ActionResult Adminsil(int id) 
        {
            var silinecek=c.Blogs.Find(id);
            c.Blogs.Remove(silinecek);
            c.SaveChanges();

            return RedirectToAction("Index");

        }



        // ilgili blogu çekme
        [Authorize]
        public ActionResult Bloggüncelle(int id)

        {
            var b1=c.Blogs.Find(id);

            return View("Bloggüncelle",b1);
        }

        // güncelleme kısmı  
        [Authorize]
        public ActionResult Bloggüncelle2(Blog g)

        {
            var güncelle = c.Blogs.Find(g.id);
            güncelle.baslik = g.baslik;
            güncelle.tarih = g.tarih;
            güncelle.aciklama = g.aciklama;
            güncelle.blogImg = g.blogImg;

            c.SaveChanges();

            return RedirectToAction("Index");
        }






        // Blog ekleme kısmı 
        [Authorize]
        [HttpGet]
        public ActionResult Adminekle()
        {
            return View();
        }



        [HttpPost]
        [Authorize]
        public ActionResult Adminekle(Blog b1)
        {
            c.Blogs.Add(b1);
            c.SaveChanges();
            return RedirectToAction("Index");
        }





        // admin yorum 
        [Authorize]
        public ActionResult Yorumlar()
        {
            var yorumlar=c.Yorumlars.ToList();
            return View(yorumlar);
        }


        // yorum silme
        [Authorize]
        public ActionResult Yorumsil(int id)
        {
            var silinecek=c.Yorumlars.Find(id);
            c.Yorumlars.Remove(silinecek);
            c.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}