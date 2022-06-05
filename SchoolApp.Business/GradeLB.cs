using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Data;

namespace SchoolApp.Business
{
    public class GradeLB
    {
        public static List<Grade> GetAll()
        {
            return GradeLD.GetAll();
        }

        public static Grade GetById(Guid id)
        {
            return GradeLD.GetById(id);
        }
        public static Grade Insert(Grade Grade)
        {
            return GradeLD.Insert(Grade);
        }
        public static Grade Update(Grade Grade)
        {
            return GradeLD.Update(Grade);
        }
        public static void DeleteById(Guid id)
        {
            GradeLD.DeleteById(id);
        }
    }
}
