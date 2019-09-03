using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 审批表
    /// </summary>
    public class Approval
    {
        public int Id { get; set; }//Id
        public string Name { get; set; }//姓名
        public int IsAllowModify { get; set; }//IsAllowModify
        public int IsAllowVersion { get; set; }//IsAllowVersion
        public string Creator { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
