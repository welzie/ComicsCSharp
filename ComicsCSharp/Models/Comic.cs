using System.Collections.Generic;

namespace ComicsCSharp.Models
{
    public class Comic
    {
        public int ComicId { get; private set; }
        public string Title { get; set; }
        public int IssueNumber { get; set; }
        private static int nextId = 0;

        public Comic()
        {
            this.ComicId = nextId;
            nextId++;
        }

        public Comic(string title, int issueNumber)
        {
            this.Title = title;
            this.IssueNumber = issueNumber;
        }

    }
}
