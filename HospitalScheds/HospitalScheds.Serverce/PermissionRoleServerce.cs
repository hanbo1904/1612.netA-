using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public class PermissionRoleServerce : IPermissionRoleServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <returns></returns>
        public int Add(IPermissionRoleServerce permissionRole)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelPermissionRole(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IPermissionRoleServerce> GetPermissionRole(string Name = "")
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IPermissionRoleServerce GetPermissionRole(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="permissionRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetPermissionRole(IPermissionRoleServerce permissionRole, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
