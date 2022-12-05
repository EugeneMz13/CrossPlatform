using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TaskAuthenticationAuthorization.Models;

namespace TaskAuthenticationAuthorization.Controllers
{
    [Authorize(Roles ="admin")]
    public class UsersController : Controller
    {
        private readonly ShoppingContext _context;

        public UsersController(ShoppingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Users.Include(u => u.Customer).Include(u => u.Role));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var user = _context.Users.Where(u => u.Id == id).Include(u => u.Customer).Include(u => u.Role).FirstOrDefault();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            if (user != null)
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var user = _context.Users.Include(u => u.Role).FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                if (user.Role.Name != "admin")
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
