using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Models.Classes;

namespace TatilSeyahat.Controllers
{
    public class AboutController : Controller
    {
        // GET: About

        Context c = new Context(); //contex sınıfından nesne ürettik
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList();
            return View(degerler);
        }
    }
}