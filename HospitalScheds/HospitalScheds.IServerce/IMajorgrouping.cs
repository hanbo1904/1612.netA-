using System;
using System.Collections.Generic;
using System.Text;


using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 专业分组设置
    /// </summary>
    public interface IMajorgrouping
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <returns></returns>
        int Add(IMajorgrouping majorgrouping);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IMajorgrouping> GetMajorgrouping(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IMajorgrouping GetMajorgrouping(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="majorgrouping"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetMajorgrouping(IMajorgrouping majorgrouping, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelMajorgrouping(int Id);
    }
}
