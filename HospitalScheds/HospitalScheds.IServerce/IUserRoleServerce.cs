using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    public  interface IUserRoleServerce
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        int Add(UserRole userRole);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<UserRole> GetUserRole(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        UserRole GetUserRole(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetUserRole(UserRole userRole, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelUserRole(int Id);

    }
}
