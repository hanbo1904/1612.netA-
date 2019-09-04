using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.IServerce;
using HospitalScheds.Model;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class IRoleServerce : IRole
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int Add(IRole role)
        {
            throw new NotImplementedException();
        }

    /// <summary>
    /// 显示
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
        public int DelRole(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IRole> GetRole(string Name = "")
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IRole GetRole(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="role"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetRole(IRole role, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
