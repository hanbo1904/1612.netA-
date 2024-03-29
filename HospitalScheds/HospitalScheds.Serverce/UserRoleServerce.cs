﻿using System;
using System.Collections.Generic;
using System.Text;


using HospitalScheds.Model;
using HospitalScheds.IServerce;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 用户角色关联表
    /// </summary>
    public class UserRoleServerce : IUserRoleServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public int Add(IUserRoleServerce userRole)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int DelUserRole(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IUserRoleServerce> GetUserRole(string Name = "")
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IUserRoleServerce GetUserRole(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除 
        /// </summary>
        /// <param name="userRole"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetUserRole(IUserRoleServerce userRole, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
