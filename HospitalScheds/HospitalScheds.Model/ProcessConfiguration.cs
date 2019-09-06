using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 审批流程配置表
    /// </summary>
    public class ProcessConfiguration 
    {
        public int Id { get; set; }//Id
        public int ProcessID { get; set; }//审批流程Id
        public int NodeID { get; set; }//审批节点Id
        public string ProcessCode { get; set; }//配置流程编码
        public int RoleSector { get; set; }//审批角色部门
        public int ApprovalRoleID { get; set; }//审批角色Id
        public int NextApprovalRoleID { get; set; }//下一步审批角色Id
        public int ApprovalUserID { get; set; }//审批人Id
        public int NextApprovalUserID { get; set; }//下一步审批人Id
        public int ProcessRoleID { get; set; }//使用流程角色Id
        public int JudgmentID { get; set; }//判断条件Id
        public int Condtion { get; set; }//审批状态
        public int Sort { get; set; }//排序Id
        public string Creator { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
