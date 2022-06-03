using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Data.Models;
using SchoolApp.Data;

namespace SchoolApp.Business
{
    public class StudentGradeLB
    {
        public static List<StudentsGrade> GetAll()
        {
            return StudentGradeLD.GetAll();
        }

        public static StudentsGrade GetById(Guid id)
        {
            return StudentGradeLD.GetById(id);
        }
        public static StudentsGrade Insert(StudentsGrade StudentsGrade)
        {
            return StudentGradeLD.Insert(StudentsGrade);
        }
        public static StudentsGrade Update(StudentsGrade StudentsGrade)
        {
            return StudentGradeLD.Update(StudentsGrade);
        }
        public static StudentsGrade DeleteById(Guid id)
        {
            return StudentGradeLD.GetById(id);
        }
    }
}
