using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Grade
    {
        public string GradeCode { get; set; }
        public double? Grade1 { get; set; }
        public string StudentCode { get; set; }
        public string TeacherCode { get; set; }
        public string CourseCode { get; set; }
        public string ClassCode { get; set; }

        public virtual Class ClassCodeNavigation { get; set; }
        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Student StudentCodeNavigation { get; set; }
        public virtual Teacher TeacherCodeNavigation { get; set; }
    }
}
