using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cache.Contracts.Contracts;
using Cache.Contracts.Model;

namespace Cache.Controllers
{
    public class AuthorController : Controller
    {
        IService<AuthorSummary> _Authserv;

        public AuthorController(IService<AuthorSummary> Authserv)
        {
            _Authserv = Authserv;

        }
        public ActionResult ViewAuthors()
        {
            return View(_Authserv.GetSummary());
        }
        public ActionResult SelectAuthors(int id,string bookname)
        {
            ViewBag.bookname = bookname;
            return View(_Authserv.GetSummary().Where(m=>m.Id==id));
        }
        [HttpGet]
        public ActionResult CreateAuthor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAuthor(AuthorSummary author)
        {
            _Authserv.Create(author);
            return RedirectToAction("ViewAuthors");
        }
        [HttpGet]
        public ActionResult DeleteAuthor(int id)
        {
            AuthorSummary author = _Authserv.GetSummary().FirstOrDefault(m => m.Id == id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return View(author);
        }

        [HttpPost, ActionName("DeleteAuthor")]
        public ActionResult DeleteConfirmed(int id)
        {
            _Authserv.Delete(id);
            return RedirectToAction("ViewAuthors");
        }
        [HttpGet]
        public ActionResult UpdateAuthor(int id)
        {
            AuthorSummary author = _Authserv.GetSummary().FirstOrDefault(m => m.Id == id);
            if (author == null)
            {
                return HttpNotFound();
            }
            return View(author);
        }
        [HttpPost]
        public ActionResult UpdateAuthor(AuthorSummary author)
        {
            _Authserv.Update(author);
            return RedirectToAction("ViewAuthors");
        }
    }
}