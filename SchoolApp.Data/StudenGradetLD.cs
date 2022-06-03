using System;
using System.Collections.Generic;
using System.Linq;
using SchoolApp.Data.Models;

namespace SchoolApp.Data
{
    public class StudentGradeLD
    {
        public static List<StudentsGrade> GetAll()
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.StudentsGrades.ToList();
        }

        public static StudentsGrade GetById(Guid id)
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.StudentsGrades.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefault();
        }
        public static StudentsGrade Insert(StudentsGrade StudentsGrade)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.StudentsGrades.Add(StudentsGrade);
                dbContext.SaveChanges();
                return StudentsGrade;
            }
        }
        public static StudentsGrade Update(StudentsGrade StudentsGrade)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.StudentsGrades.Update(StudentsGrade);
                dbContext.SaveChanges();
                return StudentsGrade;
            }
        }
        public static void DeleteById(Guid id)
        {
            var StudentsGrade = new StudentsGrade() { Id = id };
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Remove<StudentsGrade>(StudentsGrade);
                dbContext.SaveChanges();
            };
        }
    }
}
