using System;
using System.Collections.Generic;
using System.Text;


using System.Data;
using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 登录表
    /// </summary>
    public interface ILogin
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        int Add(ILogin login);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<ILogin> GetLogin(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ILogin GetLogin(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="login"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetLogin(ILogin login, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelLogin(int Id);
    }
}
