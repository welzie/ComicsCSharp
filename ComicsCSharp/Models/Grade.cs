using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsCSharp.Models
{
    public class Grade
    {
        public String Name { get; set; }
        public int GradeId { get; set; }

        public Grade(string name, int gradeId)
        {
            this.Name = name;
            this.GradeId = gradeId;
        }
    }
}
