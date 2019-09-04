using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public interface IPermissionRole
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        int Add(IPermissionRole permissionRole);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IPermissionRole> GetPermissionRole(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IPermissionRole GetPermissionRole(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetPermissionRole(IPermissionRole permissionRole, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelPermissionRole(int id);
    }
}
