using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeziSitesi.Models.Classlar;

namespace GeziSitesi.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context db=new Context();
        public ActionResult Index()
        {
            var bloglar=db.Blogs.ToList();
            return View(bloglar);
        }
        // blog detay sayfası 
        BlogYorum by=new BlogYorum();

        public ActionResult BlogDetay(int id ) 
        {
        
            by.deger1=db.Blogs.Where(x=>x.id==id).ToList();
            by.deger2=db.Yorumlars.Where(k=>k.blogI_ıd==id).ToList();
            

           
            return View(by);
        }
    }
}