using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class StudentViewModel
    {
        public StudentViewModel()
        {
            Attendances = new HashSet<AttendanceViewModel>();
            Enrollments = new HashSet<EnrollmentViewModel>();
            Grades = new HashSet<GradeViewModel>();
        }

        public string StudentCode { get; set; }
        public string StudentName { get; set; }
        public string StudentAddress { get; set; }
        public string ClassCode { get; set; }
        public string StudentPhone { get; set; }
        public string StudentMail { get; set; }
        public int? Status { get; set; }
        public int? AccountId { get; set; }
        public virtual AccountViewModel Account { get; set; }
        public virtual ClassViewModel ClassCodeNavigation { get; set; }
        public virtual ICollection<AttendanceViewModel> Attendances { get; set; }
        public virtual ICollection<EnrollmentViewModel> Enrollments { get; set; }
        public virtual ICollection<GradeViewModel> Grades { get; set; }
    }
}
