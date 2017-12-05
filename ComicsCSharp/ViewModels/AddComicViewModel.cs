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
        public int? Grade { get; set; }
        
        public List<SelectListItem> SelectItems { get; } = new List<SelectListItem>()
        {
            new SelectListItem() { Value = "0", Text="Mint"},
            new SelectListItem() { Value="1",Text="Fair"},
            new SelectListItem() {Value="2",Text="Poor"}
        };

    }
}
