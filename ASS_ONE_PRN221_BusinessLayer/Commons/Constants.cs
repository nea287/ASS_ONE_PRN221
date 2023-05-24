using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS_ONE_PRN221_BusinessLayer.Commons
{
    public static class Constants
    {
        //Account
        public const string SUC_CREATE_ACCOUNT = "Tạo tài khoản thành công rồi!";
        public const string SUC_UPDATE_ACCOUNT = "Update tài khoản thành công!";
        public const string ERROR_CREATE_ACCOUNT = "Tạo tài khoản thất bại!";
        public const string ERROR_UPDATE_ACCOUNT = "Cập nhật tài khoản thất bại!";
        public const string NOT_FOUND_ACCOUNT = "Không tìm thấy tài khoản";
        public const string WRONG_USERNAME_PASSWORD = "Sai Username hoặc Password rồi!";
        public const string EXISTED_USERNAME = "Username đã tồn tại!";
        //Role Account 
        public const int TEACHER = 2;
        public const int STUDENT = 3;

        //Page
        public const int DefaultPaging = 50;
        public const int LimitPaging = 500;
        public const int DefaultPage = 1;
    }
}
