using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using HospitalScheds.IServerce;

namespace HospitalScheds.Serverce
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class IUserInfoServerce : IUserInfo
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int Add(IUserInfo userInfo)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelUserInfo(int id)
        {
            throw new NotImplementedException();
        }

        public int DelUserInfos(int id)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IUserInfo GetUserInfo(int Id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public List<IUserInfo> GetUserInfo(string Name = "")
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="userInfo"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int GetUserInfo(IUserInfo userInfo, int Id)
        {
            throw new NotImplementedException();
        }
        
    }
}
