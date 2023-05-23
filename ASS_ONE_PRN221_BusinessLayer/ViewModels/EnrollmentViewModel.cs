using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class EnrollmentViewModel
    {
        public string StudentCode { get; set; }
        public string CourseCode { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? Grade { get; set; }
        public int? Status { get; set; }
        public string EnrollmentCode { get; set; }

        public virtual CourseViewModel CourseCodeNavigation { get; set; }
        public virtual StudentViewModel StudentCodeNavigation { get; set; }
    }
}
