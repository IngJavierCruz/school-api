using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Data;

namespace SchoolApp.Business
{
    public class TeacherLB
    {
        public static List<Teacher> GetAll()
        {
            return TeacherLD.GetAll();
        }

        public static Teacher GetById(Guid id)
        {
            return TeacherLD.GetById(id);
        }
        public static Teacher Insert(Teacher Teacher)
        {
            return TeacherLD.Insert(Teacher);
        }
        public static Teacher Update(Teacher Teacher)
        {
            return TeacherLD.Update(Teacher);
        }
        public static void DeleteById(Guid id)
        {
            TeacherLD.DeleteById(id);
        }
    }
}
