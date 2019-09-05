using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    ///权限表接口
    /// </summary>
    public interface IPermissionServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        int Add(Permission permission);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<Permission> GetPermission(string Name="");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Permission GetPermission(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetPermission(Permission permission, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelPermission(int Id);
      
        }
}
