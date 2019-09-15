using HospitalScheds.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 专业分组设置
    /// </summary>
    public interface IMajorgroupServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="announcementform"></param>
        /// <returns></returns>
        int Add(Majorgrouping majorgrouping);

        /// <summary>
        /// 显示分页
        /// </summary>
        /// <typeparam name="announcementform"></typeparam>
        /// <param name="Name"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        List<Majorgrouping> GetMajor();

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Delete(int ids);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="dd"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        int Update(Majorgrouping majorgrouping, int id);
    }
}
