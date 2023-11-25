using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var value = context.Blogs.Find(id);
            context.Blogs.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlog", blog);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blog = context.Blogs.Find(b.ID);
            blog.Description = b.Description;
            blog.Title = b.Title;
            blog.BlogImage = b.BlogImage;
            blog.Tarih = b.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var values = context.Commentss.ToList();
            return View(values);
        }
        public ActionResult DeleteComment(int id)
        {
            var value = context.Commentss.Find(id);
            context.Commentss.Remove(value);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
        public ActionResult GetComment(int id)
        {
            var comment = context.Commentss.Find(id);
            return View("GetComment", comment);
        }
        public ActionResult UpdateComment(Comments c)
        {
            var comment = context.Commentss.Find(c.ID);
            comment.Username = c.Username;
            comment.Mail = c.Mail;
            comment.Comment = c.Comment;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}