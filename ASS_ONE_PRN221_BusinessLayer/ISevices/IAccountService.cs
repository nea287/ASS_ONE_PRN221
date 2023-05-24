using ASS_ONE_PRN221_BusinessLayer.RequestModels.AccountRequestModels;
using ASS_ONE_PRN221_BusinessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.ISevices
{
    public interface IAccountService
    {
        public ResponseResult<AccountViewModel> GetAccount(int accountID);
        public ResponseResult<AccountViewModel> GetAccountByUsername(string username, string password);
        public DynamicModelResponse.DynamicModelsResponse<AccountViewModel> GetAccounts(int page, int size);
        ResponseResult<AccountViewModel> CreateAccount(CreateAccountRequestModel account);
        ResponseResult<AccountViewModel> UpdateAccount(UpdateAccountRequestModel account);

    }
}
