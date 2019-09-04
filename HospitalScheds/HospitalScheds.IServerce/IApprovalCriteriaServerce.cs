using System;
using System.Collections.Generic;
using System.Text;

using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 审批条件
    /// </summary>
    public interface IApprovalCriteriaServerce
    {
        
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        PageModel<ApprovalCriteria> GetApprovalCriteria(int pageIndex = 1, int pageSize = 3);

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int AddApprovalCriteria(ApprovalCriteria approvalCriteria);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="crewscheduling"></param>
        /// <returns></returns>
        int EditApprovalCriteria(ApprovalCriteria approvalCriteria);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ApprovalCriteria GetModel(int id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteApprovalCriteria(int id);
    }
}
