using ComicsCSharp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComicsCSharp.ViewModels
{
    public class AddComicViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int? IssueNumber { get; set; }
        public int? GradeId { get; set; }

        public List<SelectListItem> SelectItems { get; } = new List<SelectListItem>();

        public AddComicViewModel()
        {
            // Use the Grade objects to create the SelectListItem objects
            foreach (Grade grade in ComicsData.GetAllGrades())
            {
                string idString = grade.GradeId.ToString();
                this.SelectItems.Add(new SelectListItem() { Value = idString, Text = grade.Name });
            }
        }

    }
}
