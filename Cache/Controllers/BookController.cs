using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cache.Contracts.Contracts;
using Cache.Contracts.Model;

namespace Cache.Controllers
{
    public class BookController : Controller
    {
        IService<BookSummary> _Bookrepo;
        public BookController(IService<BookSummary> Bookrepo)
        {
            _Bookrepo = Bookrepo;
        }
        // GET: Book
        public ActionResult ViewBooks()
        {
            return View(_Bookrepo.GetSummary());
        }
        [HttpGet]
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBook(BookSummary book)
        {
            _Bookrepo.Create(book);
            return RedirectToAction("ViewBooks");
        }
        [HttpGet]
        public ActionResult DeleteBook(int id)
        {
            BookSummary book = _Bookrepo.GetSummary().FirstOrDefault(m => m.Id==id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("DeleteBook")]
        public ActionResult DeleteConfirmed(int id)
        {
            _Bookrepo.Delete(id);
            return RedirectToAction("ViewBooks");
        }
        [HttpGet]
        public ActionResult UpdateBook(int id)
        {
            BookSummary book = _Bookrepo.GetSummary().FirstOrDefault(m => m.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        public ActionResult UpdateBook(BookSummary book)
        {
            _Bookrepo.Update(book);
            return RedirectToAction("ViewBooks");
        }
    }
}