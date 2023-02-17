
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
   
    public class BooksController : Controller
    {
        private readonly LibraryContext _db;

        public BooksController(LibraryContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Books> objCategoryList = _db.Books;
            return View(objCategoryList);
        }


        public ActionResult Details(int id)
        {
            return View(_db.Books.ToList().FirstOrDefault(x => x.ID == id));
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Books books)
        {
            try
            {
                _db.Books.Add(books);
                _db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //GET: BooksController/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id)
        {
            return View();

        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int id, Books book)
        {
            var bookDB = _db.Books.ToList().FirstOrDefault(x => x.ID == id);
            bookDB.Title = book.Title;
            bookDB.Author = book.Author;
            bookDB.BookEditionYear = book.BookEditionYear;



            try
            {
                _db.Update(bookDB);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // GET: BooksController/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            return View(_db.Books.ToList().FirstOrDefault(x => x.ID == id));
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id, Books books)
        {
            try
            {
                _db.Books.Remove(books);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Reserve(int id)
        {
            return View(_db.Books.ToList().FirstOrDefault(x => x.ID == id));
        }

        public ActionResult ReserveConfirmation(int id, DateTime date_from, DateTime date_to)
        {
            Books book = _db.Books.ToList().FirstOrDefault(x => x.ID == id);
            if (date_from > DateTime.Now)
                return Reserve(id);

            return View();
        }
    }
}
