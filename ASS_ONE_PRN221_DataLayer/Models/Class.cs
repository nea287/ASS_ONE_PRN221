using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Class
    {
        public Class()
        {
            Attendances = new HashSet<Attendance>();
            Grades = new HashSet<Grade>();
            Students = new HashSet<Student>();
            Teachers = new HashSet<Teacher>();
            Timetables = new HashSet<Timetable>();
        }

        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Timetable> Timetables { get; set; }
    }
}
