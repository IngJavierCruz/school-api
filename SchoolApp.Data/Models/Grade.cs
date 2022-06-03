using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Data.Models
{
    public partial class Grade
    {
        public Grade()
        {
            StudentsGrades = new HashSet<StudentsGrade>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TeacherId { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<StudentsGrade> StudentsGrades { get; set; }
    }
}
