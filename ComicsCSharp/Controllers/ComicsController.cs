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
                comic.Grade = ComicsData.GetGradeById(comicViewModel.GradeId.Value);
                ComicsData.Add(comic);
                //return RedirectToAction("Index", new { name = "blake" });
                return Redirect("/Comics");
            }
            // Bad news, stuff is not right
            // Stay, so the user can finish form
            return View(comicViewModel);
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
