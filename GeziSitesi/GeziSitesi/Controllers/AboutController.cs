using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;
using System.Web.Mvc;
using GeziSitesi.Models.Classlar;

namespace GeziSitesi.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context db=new Context();
        public ActionResult Index()
        {
            var hakkım=db.Hakkımızdas.ToList();
            return View(hakkım);

        }
    }
}