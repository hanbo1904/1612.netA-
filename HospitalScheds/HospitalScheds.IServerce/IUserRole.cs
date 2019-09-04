using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    public  interface IUserRole
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        int Add(IUserRole userRole);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IUserRole> GetUserRole(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IUserRole GetUserRole(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetUserRole(IUserRole userRole, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelUserRole(int Id);

    }
}
