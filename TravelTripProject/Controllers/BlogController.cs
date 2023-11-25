using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;


namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogComment blogComment = new BlogComment();

        public ActionResult Index()
        {
            //var values = context.Blogs.ToList();
            blogComment.Value1 = context.Blogs.ToList();
            blogComment.Value3 = context.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(blogComment);
        }
        public ActionResult BlogDetail(int id)
        {
            blogComment.Value1 = context.Blogs.Where(x => x.ID == id).ToList();
            blogComment.Value2 = context.Commentss.Where(x => x.BlogID == id).ToList();
            return View(blogComment);
        }
        [HttpGet]
        public PartialViewResult Comment(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Comment(Comments c)
        {
            context.Commentss.Add(c);
            context.SaveChanges();
            return PartialView();
        }
    }
}