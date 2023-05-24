using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class TeacherViewModel
    {
        public TeacherViewModel()
        {
            Grades = new HashSet<GradeViewModel>();
            Timetables = new HashSet<TimetableViewModel>();
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

        //public virtual AccountViewModel Account { get; set; }
        public virtual ClassViewModel ClassCodeNavigation { get; set; }
        public virtual CourseViewModel CourseCodeNavigation { get; set; }
        public virtual ICollection<GradeViewModel> Grades { get; set; }
        public virtual ICollection<TimetableViewModel> Timetables { get; set; }
    }
}
