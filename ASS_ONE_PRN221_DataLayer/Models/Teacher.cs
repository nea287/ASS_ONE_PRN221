using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Grades = new HashSet<Grade>();
            Timetables = new HashSet<Timetable>();
        }

        public string TeacherCode { get; set; }
        public string TeacherName { get; set; }
        public string Address { get; set; }
        public string ClassCode { get; set; }
        public string CourseCode { get; set; }
        public int? Status { get; set; }
        public int? AccountId { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string TeacherAddress { get; set; }

        public virtual Account Account { get; set; }
        public virtual Class ClassCodeNavigation { get; set; }
        public virtual Course CourseCodeNavigation { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
