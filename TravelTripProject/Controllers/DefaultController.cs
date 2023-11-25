using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Sınıflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(10).ToList();
            return View(values);
        }
        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial2()
        {
            var value = context.Blogs.Where(x => x.ID == 2).ToList();
            return PartialView(value);  
        }
        public PartialViewResult Partial3()
        {
            var values = context.Blogs.Take(10).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial4()
        {
            var values = context.Blogs.Take(3).ToList();
            return PartialView(values);
        }
        public PartialViewResult Partial5()
        {
            var values = context.Blogs.Take(3).OrderByDescending(x =>x.ID).ToList();
            return PartialView(values);
        }
    }
}