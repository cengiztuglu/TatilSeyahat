using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahat.Controllers;
using TatilSeyahat.Models.Classes;

namespace TatilSeyahat.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            Context c = new Context();
            var bloglar = c.Blogs.ToList();
            
            return View(bloglar);
        }
    }
}