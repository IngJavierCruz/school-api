using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Data.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentsGrades = new HashSet<StudentsGrade>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthday { get; set; }

        public virtual ICollection<StudentsGrade> StudentsGrades { get; set; }
    }
}
