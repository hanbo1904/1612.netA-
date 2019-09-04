using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 审批流程配置表
    /// </summary>
    public interface IProcessConfigurationServerce
    {
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<ProcessConfiguration> GetProcessConfiguration(int pageIndex = 1, int pageSize = 3);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddProcessConfiguration(ProcessConfiguration processConfiguration);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditProcessConfiguration(ProcessConfiguration processConfiguration);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProcessConfiguration GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteProcessConfiguration(int id);
    }
}
