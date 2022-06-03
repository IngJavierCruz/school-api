using System;
using System.Collections.Generic;

#nullable disable

namespace SchoolApp.Data.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Grades = new HashSet<Grade>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }

        public virtual ICollection<Grade> Grades { get; set; }
    }
}
