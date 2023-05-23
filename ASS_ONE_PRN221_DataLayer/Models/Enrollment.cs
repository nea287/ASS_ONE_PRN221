using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Enrollment
    {
        public string StudentCode { get; set; }
        public string CourseCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? Grade { get; set; }
        public int? Status { get; set; }
        public string EnrollmentCode { get; set; }

        public virtual Course CourseCodeNavigation { get; set; }
        public virtual Student StudentCodeNavigation { get; set; }
    }
}
