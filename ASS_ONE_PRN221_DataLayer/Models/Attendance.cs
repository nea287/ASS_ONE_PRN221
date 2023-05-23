using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Attendance
    {
        public string AttendanceCode { get; set; }
        public string StudentCode { get; set; }
        public DateTime? AttendanceDate { get; set; }
        public bool? IsPresent { get; set; }
        public string ClassCode { get; set; }
        public string CourseCode { get; set; }
        public int? Slot { get; set; }

        public virtual Class ClassCodeNavigation { get; set; }
        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Student StudentCodeNavigation { get; set; }
    }
}
