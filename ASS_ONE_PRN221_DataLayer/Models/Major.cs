using System;
using System.Collections.Generic;

#nullable disable

namespace ASS_ONE_PRN221_DataLayer.Models
{
    public partial class Major
    {
        public Major()
        {
            Courses = new HashSet<Course>();
        }

        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
