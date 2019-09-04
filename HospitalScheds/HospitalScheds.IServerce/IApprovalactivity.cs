using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 审批活动表
    /// </summary>
    public interface IApprovalactivity
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="approvalactivity"></param>
        /// <returns></returns>
        int Add(IApprovalactivity approvalactivity);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<IApprovalactivity> GetApprovalactivity(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        IApprovalactivity GetApprovalactivity(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="approvalactivity"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetApprovalactivity(IApprovalactivity approvalactivity, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelApprovalactivity(int Id);
    }
}
