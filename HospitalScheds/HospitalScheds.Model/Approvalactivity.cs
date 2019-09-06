using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 审批活动表
    /// </summary>
    public class Approvalactivity 
    {
        public int Id { get; set; }//Id
        public int ProcessID { get; set; }//审批流程Id
        public int NodeID { get; set; }//审批节点Id
        public string ProcessCode { get; set; }//配置流程编码
        public string RoleSector { get; set; }//审批角色部门
        public int ApprovalRoleID { get; set; }//审批角色Id
        public int NextApprovalRoleID { get; set; }//下一步审批角色Id
        public int ApprovalUserID { get; set; }//审批人Id
        public int NextApprovalUserID { get; set; }//下一步审批人Id
        public int ProcessRoleID { get; set; }//使用流程角色Id
        public int JudgmentID { get; set; }//判断条件Id
        public int Condtion { get; set; }//审批状态
        public int IsAllowModity { get; set; }//是否修改过
        public int IsAllowVersion { get; set; }//是否撤销
        public string ApprovalUser { get; set; }//实际审批人
        public string ApprovalOpinion { get; set; }//审批意见
        public int TureCondtion { get; set; }//实际审批状态
        public DateTime ApprovalTime { get; set; }//审批时间
        public string Creator { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
