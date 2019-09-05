using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfoServerce : IUserInfoServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int Add(IUserInfoServerce userInfoServerce)
        {
            throw new NotImplementedException();
        }

        public int AddUser(UserInfo user)
        {
            throw new NotImplementedException();
        }

        public int DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelUserInfo(int id)
        {
            throw new NotImplementedException();
        }

        public int DelUserInfos(int id)
        {
            throw new NotImplementedException();
        }

        public int EditUser(UserInfo user)
        {
            throw new NotImplementedException();
        }

        public UserInfo GetModel(int id)
        {
            throw new NotImplementedException();
        }

        public PageModel<UserInfo> GetUserInfo(string name = "", int pageIndex = 1, int pageSize = 3)
        {
            throw new NotImplementedException();
        }
    }
}
