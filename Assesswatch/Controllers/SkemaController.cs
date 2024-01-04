using Assesswatch.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assesswatch.Controllers
{
    public class SkemaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(string id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
