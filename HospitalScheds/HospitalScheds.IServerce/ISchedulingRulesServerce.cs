using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;
using System.Data;

namespace HospitalScheds.IServerce
{
    public interface ISchedulingRulesServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="schedulingRules"></param>
        /// <returns></returns>
        int Add(ISchedulingRulesServerce schedulingRules);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<ISchedulingRulesServerce> GetSchedulingRules(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ISchedulingRulesServerce GetSchedulingRules(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="schedulingRules"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetSchedulingRules(ISchedulingRulesServerce schedulingRules, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelSchedulingRules(int Id);

    }
}
