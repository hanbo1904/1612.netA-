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
    public interface IApprovalactivityServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="approvalactivity"></param>
        /// <returns></returns>
        int Add(Approvalactivity approvalactivity);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<Approvalactivity> GetApprovalactivity(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Approvalactivity GetApprovalactivity(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="approvalactivity"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetApprovalactivity(Approvalactivity approvalactivity, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelApprovalactivity(int Id);
    }
}
