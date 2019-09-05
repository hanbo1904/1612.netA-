using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using HospitalScheds.Model;

namespace HospitalScheds.IServerce
{
    /// <summary>
    /// 审批表
    /// </summary>
    public interface IApprovalServerce
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="approval"></param>
        /// <returns></returns>
        int Add(Approval approval);

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        List<Approval> GetApproval(string Name = "");

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        Approval GetApproval(int Id);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="approval"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        int GetPermission(Approval approval, int Id);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DelApproval(int Id);
    }
}
