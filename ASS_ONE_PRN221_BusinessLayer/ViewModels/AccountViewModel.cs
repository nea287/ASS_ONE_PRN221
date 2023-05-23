using ASS_ONE_PRN221_DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ViewModels
{
    public class AccountViewModel
    {
        public AccountViewModel()
        {
            Students = new HashSet<StudentViewModel>();
            Teachers = new HashSet<TeacherViewModel>();
        }
        //public int AccountId { get; set; }
        public string Username { get; set; }
        //public string Password { get; set; }
        public int? Role { get; set; }
        //public int? Status { get; set; }
        public virtual ICollection<StudentViewModel> Students { get; set; }
        public virtual ICollection<TeacherViewModel> Teachers { get; set; }

    }
}
