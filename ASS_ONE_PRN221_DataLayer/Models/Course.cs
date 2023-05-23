using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Course
    {
        public Course()
        {
            Attendances = new HashSet<Attendance>();
            Enrollments = new HashSet<Enrollment>();
            Grades = new HashSet<Grade>();
            Teachers = new HashSet<Teacher>();
            Timetables = new HashSet<Timetable>();
        }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string MajorCode { get; set; }
        public int? Status { get; set; }

        public virtual Major MajorCodeNavigation { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
