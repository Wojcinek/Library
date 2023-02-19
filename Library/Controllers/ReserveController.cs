using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library.Areas.Identity.Data;
using Library.Data;
using Library.Migrations;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Library.Controllers
{
    public class ReserveController : Controller
    {
        private readonly LibraryContext _context;
        private readonly UserManager<LibraryUser> _userManager;

        public ReserveController(LibraryContext context, UserManager<LibraryUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
     
        public ActionResult Index()
        {
            var userid = _userManager.GetUserId(User);
            return View(_context.Reserve
                .Include(b => b.book)
                .Include(u => u.user)
                .ToList().Where(x => x.user.Id == userid));
                
        }


        // GET: RentalsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Reserve.ToList().FirstOrDefault(x => x.id_rental == id));
        }

        // POST: RentalsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Reserve rental)
        {
            try
            {
                _context.Remove(rental);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
