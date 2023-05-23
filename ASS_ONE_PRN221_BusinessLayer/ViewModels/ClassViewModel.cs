using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class ClassViewModel
    {
        public ClassViewModel()
        {
            Attendances = new HashSet<AttendanceViewModel>();
            Grades = new HashSet<GradeViewModel>();
            Students = new HashSet<StudentViewModel>();
            Teachers = new HashSet<TeacherViewModel>();
            Timetables = new HashSet<TimetableViewModel>();
        }

        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<AttendanceViewModel> Attendances { get; set; }
        public virtual ICollection<GradeViewModel> Grades { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public virtual ICollection<TeacherViewModel> Teachers { get; set; }
        public virtual ICollection<TimetableViewModel> Timetables { get; set; }
    }
}
