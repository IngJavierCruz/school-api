using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Data.Models
{
    public partial class StudentsGrade
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid GradeId { get; set; }
        public string Seccion { get; set; }

        public virtual Grade Grade { get; set; }
        public virtual Student Student { get; set; }
    }
}
