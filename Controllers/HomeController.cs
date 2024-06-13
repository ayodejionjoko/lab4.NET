using Microsoft.AspNetCore.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SongForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sing(int numberOfMonkeys)
        {
            ViewBag.NumberOfMonkeys = numberOfMonkeys;
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DisplayStudent(Student student)
        {
            return View(student);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
