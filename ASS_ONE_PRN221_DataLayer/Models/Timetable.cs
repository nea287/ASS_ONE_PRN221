using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Timetable
    {
        public string TimetableCode { get; set; }
        public string ClassCode { get; set; }
        public string CourseCode { get; set; }
        public string TeacherCode { get; set; }
        public int? Slot { get; set; }
        public int? Room { get; set; }

        public virtual Class ClassCodeNavigation { get; set; }
        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Teacher TeacherCodeNavigation { get; set; }
    }
}
