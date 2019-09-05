using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 连休
    /// </summary>
    public interface IStraight
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="straight"></param>
        /// <returns></returns>
        int Add(IStraight straight);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IStraight> GetStraight(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IStraight GetStraight(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="straight"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetStraight(IStraight straight, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelPermission(int Id);
    }
}
