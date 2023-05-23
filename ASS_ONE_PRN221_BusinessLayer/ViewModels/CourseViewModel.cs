using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            Attendances = new HashSet<AttendanceViewModel>();
            Enrollments = new HashSet<EnrollmentViewModel>();
            Grades = new HashSet<GradeViewModel>();
            Teachers = new HashSet<TeacherViewModel>();
            Timetables = new HashSet<TimetableViewModel>();
        }

        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string MajorCode { get; set; }
        public int? Status { get; set; }

        public virtual MajorViewModel MajorCodeNavigation { get; set; }
        public virtual ICollection<AttendanceViewModel> Attendances { get; set; }
        public virtual ICollection<EnrollmentViewModel> Enrollments { get; set; }
        public virtual ICollection<GradeViewModel> Grades { get; set; }
        public virtual ICollection<TeacherViewModel> Teachers { get; set; }
        public virtual ICollection<TimetableViewModel> Timetables { get; set; }
    }
}
