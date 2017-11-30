using System.Collections.Generic;

namespace ComicsCSharp.Models
{
    public class Comic
    {
  
        public string Title { get; set; }
        public int IssueNumber { get; set; }

        

        public Comic(string title, int IssueNumber)
        {
            this.Title = title;
            this.IssueNumber = IssueNumber;
        }

    }
}
