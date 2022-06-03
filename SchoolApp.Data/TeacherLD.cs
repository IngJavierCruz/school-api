using System;
using System.Collections.Generic;
using System.Linq;
using SchoolApp.Data.Models;

namespace SchoolApp.Data
{
    public class TeacherLD
    {
        public static List<Teacher> GetAll()
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Teachers.ToList();
        }

        public static Teacher GetById(Guid id)
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Teachers.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefault();
        }
        public static Teacher Insert(Teacher Teacher)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Teachers.Add(Teacher);
                dbContext.SaveChanges();
                return Teacher;
            }
        }
        public static Teacher Update(Teacher Teacher)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Teachers.Update(Teacher);
                dbContext.SaveChanges();
                return Teacher;
            }
        }
        public static void DeleteById(Guid id)
        {
            var Teacher = new Teacher() { Id = id };
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Remove<Teacher>(Teacher);
                dbContext.SaveChanges();
            };
        }
    }
}
