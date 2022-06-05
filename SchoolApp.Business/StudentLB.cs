using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Data;

namespace SchoolApp.Business
{
    public class StudentLB
    {
        public static List<Student> GetAll()
        {
            return StudentLD.GetAll();
        }

        public static Student GetById(Guid id)
        {
            return StudentLD.GetById(id);
        }
        public static Student Insert(Student student)
        {
            return StudentLD.Insert(student);
        }
        public static Student Update(Student student)
        {
            return StudentLD.Update(student);
        }
        public static void DeleteById(Guid id)
        {
            StudentLD.DeleteById(id);
        }
    }
}
