using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ComicsCSharp.Models;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {

        private static List<Comic> comics = new List<Comic>();

        public IActionResult Index()
        {
            ViewBag.comics = comics;
            return View();
        }

        [HttpPost]
        public IActionResult Add(string title, int issueNumber)
        {
            var comic = new Comic(title, issueNumber);
            comics.Add(comic);
            return Redirect("/Comics");
        }
    }
}
