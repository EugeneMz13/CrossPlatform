using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskAuthenticationAuthorization.Models;
using TaskAuthenticationAuthorization.ViewModels;

namespace TaskAuthenticationAuthorization.Controllers
{
    public class LabsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Lab1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lab1(Lab1Model model)
        {
            int a, b;
            a = model.x;
            b = model.y;
            for (int i = 1; i != a + 1; ++i)
            {
                for (int j = 1; j != b + 1; ++j)
                {
                    model.answer += i * j;
                }
            }
            ViewData["result"] = model.answer;
            return View(model);
        }
        [HttpGet]
        public IActionResult Lab2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lab2(Lab2Model model)
        {
            int b = model.x;
            var def = 1;
            for (int i = 1; i < 10000; i++)
            {
                if (i % 2 == 0)
                {
                    def += 1;
                }
                else if (i % 3 == 0)
                {
                    def += 1;
                }
                else if (i % 5 == 0)
                {
                    def += 1;
                }
                if (def == b)
                {
                    ViewData["resi"] = i;
                    return View(model);
                }
            }
            return View(model);
        }
    }
}
