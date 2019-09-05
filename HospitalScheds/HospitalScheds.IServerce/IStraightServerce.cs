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
    public interface IStraightServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="straight"></param>
        /// <returns></returns>
        int Add(Straight straight);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<Straight> GetStraight(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Straight GetStraight(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="straight"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetStraight(Straight straight, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelPermission(int Id);
    }
}
