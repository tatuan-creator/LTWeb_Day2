using Lab2_TranAnhTuan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2_TranAnhTuan.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;
        public BookController()
        {
            listBooks = new List<Book>();
            listBooks.Add(new Book()
            {
                ID = 1,
                Title = "Đắc Nhân Tâm",
                Author = "abc",
                PublicYear = 2001,
                Price = 300,
                Cover = "Content/Images/dacnhantam.jpg"
            });

            listBooks.Add(new Book()
            {
                ID = 2,
                Title = "Harry Potter và hoàng tử lai",
                Author = "J.K.Rowling",
                PublicYear = 2017,
                Price = 215,
                Cover = "Content/Images/harypotterhoangtulai.jpg"
            });

            listBooks.Add(new Book()
            {
                ID = 2,
                Title = "Harry Potter và hoàng tử lai",
                Author = "J.K.Rowling",
                PublicYear = 2017,
                Price = 215,
                Cover = "Content/Images/harypotterhoangtulai.jpg"
            });

            listBooks.Add(new Book()
            {
                ID = 2,
                Title = "Harry Potter và hoàng tử lai",
                Author = "J.K.Rowling",
                PublicYear = 2017,
                Price = 215,
                Cover = "Content/Images/harypotterhoangtulai.jpg"
            });

            listBooks.Add(new Book()
            {
                ID = 2,
                Title = "Harry Potter và hoàng tử lai",
                Author = "J.K.Rowling",
                PublicYear = 2017,
                Price = 215,
                Cover = "Content/Images/harypotterhoangtulai.jpg"
            });
        }
        // GET: Book
        public ActionResult ListBooks()
        {
            ViewBag.TitleNamePage = "Book View Page";
            return View(listBooks);
        }
        public ActionResult Detail(int? id)
        {
            if (id==null)
            {
                return HttpNotFound();
            }
            Book book = listBooks.Find(s => s.ID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
    }
}