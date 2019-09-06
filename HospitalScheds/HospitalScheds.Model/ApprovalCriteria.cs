using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 审批条件
    /// </summary>
    public class ApprovalCriteria : BaseEntity
    {
        public int Id { get; set; }//Id
        public int YeId { get; set; }//业务Id
        public string Conditions { get; set; }//审批条件
        public int Sort { get; set; }//排序号
        public string Creator { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
        public string Editor { get; set; }//编辑人
        public DateTime Edittime { get; set; }//编辑时间
    }
}
