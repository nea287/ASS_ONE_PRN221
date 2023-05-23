using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class MajorViewModel
    {
        public MajorViewModel()
        {
            Courses = new HashSet<CourseViewModel>();
        }

        public string MajorCode { get; set; }
        public string MajorName { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<CourseViewModel> Courses { get; set; }
    }
}
