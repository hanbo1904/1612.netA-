using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 用户表
    /// </summary>
    public interface IUserInfoServerce
    {
        /// <summary>
        /// 查询显示
        /// </summary>
        /// <returns></returns>
        List<UserInfo> GetUserInfo(string name = "");

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int AddUser(UserInfo user);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        int EditUser(UserInfo user);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        UserInfo GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUser(int id);
    }
}
