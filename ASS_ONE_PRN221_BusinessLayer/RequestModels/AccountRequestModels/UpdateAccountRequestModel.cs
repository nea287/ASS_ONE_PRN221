using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.RequestModels.AccountRequestModels
{
    public class UpdateAccountRequestModel
    {
        public int AccountID { get; set; }
        public string Password { get; set; }
    }
}
