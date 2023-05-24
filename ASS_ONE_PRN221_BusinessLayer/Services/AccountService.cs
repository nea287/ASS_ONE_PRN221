using ASS_ONE_PRN221_BusinessLayer.Commons;
using ASS_ONE_PRN221_BusinessLayer.ISevices;
using ASS_ONE_PRN221_BusinessLayer.RequestModels.AccountRequestModels;
using ASS_ONE_PRN221_BusinessLayer.Utilities;
using ASS_ONE_PRN221_BusinessLayer.ViewModels;
using ASS_ONE_PRN221_DataLayer.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.Services
{
    public class AccountService : IAccountService
    {
        private readonly IMapper _mapper;
        private readonly StudentManagementContext _context;

        public AccountService(IMapper mapper, StudentManagementContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        public ResponseResult<AccountViewModel> CreateAccount(CreateAccountRequestModel account)
        {
            var acc = GetAccountByUsername(account.Username);
            if(acc != null)
            {
                return new ResponseResult<AccountViewModel>()
                {
                    Message = Constants.EXISTED_USERNAME,
                };
            }
            acc = new Account()
            {
                Password = account.Password,
                Role = account.Role,
                Status = 1,
                Username = account.Username
            };
            _context.Accounts.Add(acc);
            _context.SaveChanges();
            return new ResponseResult<AccountViewModel>()
            {
                Message = Constants.SUC_CREATE_ACCOUNT,
                Value = _mapper.Map<AccountViewModel>(acc)
            };
        }
        private Account GetAccountByUsername(string username)
        {
            return _context.Accounts.FirstOrDefault(x => x.Username == username);
        }

        public ResponseResult<AccountViewModel> GetAccount(int accountID)
        {
            var account = _context.Accounts.FirstOrDefault
                (x => x.AccountId == accountID);
            if (account == null) return new ResponseResult<AccountViewModel>()
            {
                Message = Constants.NOT_FOUND_ACCOUNT,
            };
            return new ResponseResult<AccountViewModel>()
            {
                Message = "Hello " + account.Username,
                Value = _mapper.Map<AccountViewModel>(account),
            };
        }

        public ResponseResult<AccountViewModel> GetAccountByUsername(string username, string password)
        {
            var account = _context.Accounts.FirstOrDefault
                (x => x.Username.Equals(username) && x.Password.Equals(password));
            if (account == null) return new ResponseResult<AccountViewModel>()
            {
                Message = Constants.WRONG_USERNAME_PASSWORD,
            };
            return new ResponseResult<AccountViewModel>()
            {
                Message = "Hello " + username,
                Value = _mapper.Map<AccountViewModel>(account),
            };
        }

        public DynamicModelResponse.DynamicModelsResponse<AccountViewModel> GetAccounts(int page, int size)
        {
            var pagingAccount = _context.Accounts.ProjectTo<AccountViewModel>((IConfigurationProvider)this._mapper)
                .PagingIQueryable(page, size, Constants.LimitPaging, Constants.DefaultPaging);
            return new DynamicModelResponse.DynamicModelsResponse<AccountViewModel>()
            {
                Metadata = new DynamicModelResponse.PagingMetadata()
                {
                    Page = page,
                    Size = size,
                    Total = pagingAccount.Item1
                },
                Results = pagingAccount.Item2.ToList()
            };
        }

        public ResponseResult<AccountViewModel> UpdateAccount(UpdateAccountRequestModel account)
        {
            var acc = _mapper.Map<Account>(GetAccount(account.AccountID));
            acc.Password = account.Password;
            _context.Accounts.Update(acc);
            _context.SaveChanges();
            return new ResponseResult<AccountViewModel>()
            {
                Message = Constants.SUC_UPDATE_ACCOUNT,
                Value = _mapper.Map<AccountViewModel>(acc)
            };
        }
    }
}
