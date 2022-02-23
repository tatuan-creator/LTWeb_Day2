using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_TranAnhTuan.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicYear { get; set; }
        public double Price { get; set; }
        public string Cover { get; set; }
    }
}