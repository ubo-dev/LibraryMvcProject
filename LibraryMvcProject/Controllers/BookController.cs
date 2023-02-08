using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryMvcProject.Models;

namespace LibraryMvcProject.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        DbLibraryEntities db = new DbLibraryEntities();
        public ActionResult Index()
        {
            var books = db.TBLBOOK.ToList();
            return View(books);
        }
        public ActionResult Category()
        {
            var categories = db.TBLCATEGORY.ToList();
            return View(categories);
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(TBLBOOK tBLBOOK) 
        {
            db.TBLBOOK.Add(tBLBOOK);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBook(int id)
        {
            var book = db.TBLBOOK.Find(id);
            db.TBLBOOK.Remove(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBook(int id)
        {
            var book = db.TBLBOOK.Find(id);
            return View("GetBook",book);
        }

        public ActionResult UpdateBook(TBLBOOK tBLBOOK)
        {
            var book = db.TBLBOOK.Find(tBLBOOK.BOOKID);
            book.NAME = tBLBOOK.NAME;
            book.AUTHOR = tBLBOOK.AUTHOR;
            book.PAGE = tBLBOOK.PAGE;
            book.CATEGORY= tBLBOOK.CATEGORY;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}