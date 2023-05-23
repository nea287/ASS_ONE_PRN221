using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class GradeViewModel
    {
        public string GradeCode { get; set; }
        public double? Grade1 { get; set; }
        public string StudentCode { get; set; }
        public string TeacherCode { get; set; }
        public string CourseCode { get; set; }
        public string ClassCode { get; set; }

        public virtual ClassViewModel ClassCodeNavigation { get; set; }
        public virtual CourseViewModel CourseCodeNavigation { get; set; }
        public virtual StudentViewModel StudentCodeNavigation { get; set; }
        public virtual TeacherViewModel TeacherCodeNavigation { get; set; }
    }
}
