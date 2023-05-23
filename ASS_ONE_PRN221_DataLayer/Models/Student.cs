using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Student
    {
        public Student()
        {
            Attendances = new HashSet<Attendance>();
            Enrollments = new HashSet<Enrollment>();
            Grades = new HashSet<Grade>();
        }

        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string ClassCode { get; set; }
        public string StudentPhone { get; set; }
        public string StudentMail { get; set; }
        public int? Status { get; set; }
        public int? AccountId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Class ClassCodeNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
    }
}
