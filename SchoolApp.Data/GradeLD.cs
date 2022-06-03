using System;
using System.Collections.Generic;
using System.Linq;
using SchoolApp.Data.Models;

namespace SchoolApp.Data
{
    public class GradeLD
    {
        public static List<Grade> GetAll()
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Grades.ToList();
        }

        public static Grade GetById(Guid id)
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Grades.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefault();
        }
        public static Grade Insert(Grade Grade)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Grades.Add(Grade);
                dbContext.SaveChanges();
                return Grade;
            }
        }
        public static Grade Update(Grade Grade)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Grades.Update(Grade);
                dbContext.SaveChanges();
                return Grade;
            }
        }
        public static void DeleteById(Guid id)
        {
            var Grade = new Grade() { Id = id };
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Remove<Grade>(Grade);
                dbContext.SaveChanges();
            };
        }
    }
}
