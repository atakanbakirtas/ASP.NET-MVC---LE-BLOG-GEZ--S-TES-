using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GeziSitesi.Models.Classlar;

namespace GeziSitesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context db=new Context();
        public ActionResult Index()
        {
            var bloglar= db.Blogs.ToList();
            return View(bloglar);
        }



        public PartialViewResult partial1()
        {
            var sonbloglar=db.Blogs.OrderByDescending(x=>x.id).Take(2).ToList();
            return PartialView(sonbloglar);
        }

        public PartialViewResult partial2()
        {
            var sonbloglar = db.Blogs.Where(x => x.id==7).Take(6).ToList();
            return PartialView(sonbloglar);
        }

        public PartialViewResult partial3()
        {
            var topon = db.Blogs.Take(6).ToList();
            return PartialView(topon);
        }
    }
}