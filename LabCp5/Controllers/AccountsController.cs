using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TaskAuthenticationAuthorization.Models;
using TaskAuthenticationAuthorization.ViewModels;
using static TaskAuthenticationAuthorization.WebConstants;

namespace TaskAuthenticationAuthorization.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ShoppingContext _context;

        public AccountsController(ShoppingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Email== model.Email && u.Password == model.Password);
                if (user != null)
                {
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Incorrect login and (or) password");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
                if (user == null)
                {
                    user = new User() { Email = model.Email, Password = model.Password, BuyerType = BuyerType.Regular };
                    Role userRole = await _context.Roles.FirstOrDefaultAsync(r => r.Name == "buyer");
                    if (userRole != null)
                    {
                        user.Role = userRole;
                    }

                    _context.Users.Add(user);

                    await _context.SaveChangesAsync();

                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Incorrect login (or) and password");
            }
            return View(model);
        }

        private async Task Authenticate(User user)
        {
            var claim = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.Name),
                new Claim(type: "customer", user.CustomerId.ToString() ?? string.Empty),
                new Claim(type: "buyerType", user.BuyerType.ToString())
            };
            ClaimsIdentity id = new ClaimsIdentity(claim, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
