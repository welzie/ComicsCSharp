using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ComicsCSharp.Models;
using ComicsCSharp.ViewModels;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.comics = ComicsData.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            return View(new AddComicViewModel());
        }

        [HttpPost]
        public IActionResult Add(AddComicViewModel comicViewModel)
        {
            if (ModelState.IsValid)
            {
                Comic comic = new Comic(comicViewModel.Title, comicViewModel.IssueNumber);
                ComicsData.Add(comic);
                return Redirect("/Comics");
            }
            // Bad news, stuff is not right
            // Stay, so the user can finish form
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] removedComics)
        {
            foreach(int comicId in removedComics)
            {
                ComicsData.RemoveById(comicId);
            }
            return Redirect("/Comics");
        }
    }
}
