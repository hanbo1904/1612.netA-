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
    public interface IPermissionRoleServerce
    {

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        int Add(PermissionRole permissionRole);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<PermissionRole> GetPermissionRole(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        PermissionRole GetPermissionRole(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetPermissionRole(PermissionRole permissionRole, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelPermissionRole(int id);
    }
}
