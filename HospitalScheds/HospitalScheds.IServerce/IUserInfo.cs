using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    public interface IUserInfo
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        int Add(IUserInfo userInfo);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IUserInfo> GetUserInfo(String Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IUserInfo GetUserInfo(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetUserInfo(IUserInfo userInfo, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelUserInfos(int id);
    }
}
