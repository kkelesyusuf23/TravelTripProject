using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Sınıflar
{
    public class Blog
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime Tarih { get; set; }
        public string Description { get; set; }
        public string BlogImage { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }
}