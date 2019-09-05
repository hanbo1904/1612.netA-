using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class PermissionServerce : IPermission
    {
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="permission"></param>
        /// <returns></returns>
        public int Add(IPermission permission)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelPermission(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IPermission GetPermission(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="permission"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetPermission(IPermission permission, int Id)
        {
            throw new NotImplementedException();
        }
 
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IPermission> GetPermission(string Name = "")
        {
            throw new NotImplementedException();
        }

       }
    }

