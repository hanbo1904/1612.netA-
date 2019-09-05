using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 角色表接口
    /// </summary>
    public interface IRoleServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        int Add(Role role);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<Role> GetRole(String Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Role GetRole(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="role"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetRole(Role role, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelRole(int Id);
    }
}
