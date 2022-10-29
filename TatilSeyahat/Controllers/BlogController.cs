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
        Context c = new Context();
        public ActionResult Index()
        {
            
            var bloglar = c.Blogs.ToList();
            
            return View(bloglar);
        }
        BlogYorum by = new BlogYorum();
        public   ActionResult BlogDetay(int id)
        {
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.Blogid == id).ToList();
            return View(by);

        }
    }
}