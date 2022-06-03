using System;
using System.Collections.Generic;
using System.Linq;
using SchoolApp.Data.Models;

namespace SchoolApp.Data
{
    public class StudentLD
    {
        public static List<Student> GetAll()
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Students.ToList();
        }

        public static Student GetById(Guid id)
        {
            using var dbContext = new SchoolDbContext();
            return dbContext.Students.Where(x => x.Id.ToString() == id.ToString()).FirstOrDefault();
        }
        public static Student Insert(Student student)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Students.Add(student);
                dbContext.SaveChanges();
                return student;
            }
        }
        public static Student Update(Student student)
        {
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Students.Update(student);
                dbContext.SaveChanges();
                return student;
            }
        }
        public static void DeleteById(Guid id)
        {
            var student = new Student() { Id = id };
            using (var dbContext = new SchoolDbContext())
            {
                dbContext.Remove<Student>(student);
                dbContext.SaveChanges();
            };
        }

    }
}
