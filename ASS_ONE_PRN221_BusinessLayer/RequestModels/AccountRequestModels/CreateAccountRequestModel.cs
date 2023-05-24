using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.RequestModels.AccountRequestModels
{
    public class CreateAccountRequestModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
