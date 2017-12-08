﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicsCSharp.Models
{
    public class ComicsData
    {
        private static List<Comic> comics = new List<Comic>();
        private static List<Grade> grades = new List<Grade>()
        {
            new Grade("Mint", 1),
            new Grade("Fair", 2),
            new Grade("Poor", 3),
        };

        public static List<Grade> GetAllGrades()
        {
            return grades;
        }

        public static Grade GetGradeById(int id)
        {
            return grades.Find(grade => grade.GradeId == id);
        }

        public static List<Comic> GetAll()
        {
            return comics;
        }

        public static void Add(Comic comic)
        {
            comics.Add(comic);
        }

        public static void RemoveById(int id)
        {
            //Lambda
            //This line is the same as lines:
            // 30 - 36 and 41 - 44
            comics.RemoveAll(c => c.ComicId == id);

            /*
            foreach(Comic comic in comics)
            {
                if (Equals(comic, id))
                {
                    comics.Remove(comic);
                }
            }
            */
        }

        /*
        public static bool Equals(Comic comic, int id)
        {
            return comic.ComicId == id;
        }
        */
    }
}
