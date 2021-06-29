using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Buoi3.Models;
using System.Data.Entity.Migrations;

namespace Buoi3.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBook()
        {
            Book context = new Book();
            var listBook = context.SACHes.ToList();
            return View(listBook);
        }

        [Authorize]
        public ActionResult Buy(int id)
        {
            Book context = new Book();
            SACH book = context.SACHes.SingleOrDefault(p => p.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [Authorize]
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "Id,Title,Author,Descriptio_n,Images,Price")] SACH book)
        {
            Book data = new Book();
            try
            {
                if (ModelState.IsValid)
                {
                    data.SACHes.Add(book);
                    //Thực hiện tạo mới
                    data.SaveChanges();
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            var books = from tt in data.SACHes select tt;
            return View("ListBook", books);
        }

        [Authorize]
        public ActionResult EditBook(int id)
        {
            Book data = new Book();
            var books = from tt in data.SACHes select tt;
            SACH book = new SACH();
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    book = item;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook([Bind(Include = "Id,Title,Author,Descriptio_n,Images,Price")] SACH book)
        {
            Book data = new Book();
            if (ModelState.IsValid)
            {
                data.Entry(book).State = System.Data.Entity.EntityState.Modified;
                data.SaveChanges();
                return RedirectToAction("listBook");
            }
            return View(book);
        }

        [Authorize]
        public ActionResult DeleteBook(int id)
        {
            Book data = new Book();
            var books = from tt in data.SACHes select tt;
            SACH book = new SACH();
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    book = item;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

        [HttpPost]
        public ActionResult DeleteBook(int id, FormCollection collection)
        {
            Book data = new Book();
            var D_tin = data.SACHes.Where(m => m.Id == id).First();

            data.SACHes.Remove(D_tin);
            data.SaveChanges();
            var books = from tt in data.SACHes select tt;
            return RedirectToAction("ListBook", books);
        }

        [Authorize]
        public ActionResult DetailBook(int id)
        {
            Book data = new Book();
            var books = from tt in data.SACHes select tt;
            SACH book = new SACH();
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    book = item;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
    }
}