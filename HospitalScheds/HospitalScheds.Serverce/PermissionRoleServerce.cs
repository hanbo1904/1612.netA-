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
        public int Add(PermissionRole permissionRole)
        {
            throw new NotImplementedException();
        }

        public int DelPermissionRole(int id)
        {
            throw new NotImplementedException();
        }

        public List<IPermissionRoleServerce> GetPermissionRole(string Name = "")
        {
            throw new NotImplementedException();
        }

        public IPermissionRoleServerce GetPermissionRole(int Id)
        {
            throw new NotImplementedException();
        }

        public int GetPermissionRole(IPermissionRoleServerce permissionRole, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
