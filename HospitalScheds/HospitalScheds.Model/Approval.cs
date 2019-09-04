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
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        public int IsAllowModify { get; set; }//IsAllowModify
        public int IsAllowVersion { get; set; }//IsAllowVersion
        public string Creator { get; set; }//创建人
        public DateTime CreateTime { get; set; }//创建时间
    }
}
