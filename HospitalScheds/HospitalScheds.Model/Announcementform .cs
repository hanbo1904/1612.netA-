using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalScheds.Model
{
    /// <summary>
    /// 消息公布
    /// </summary>
  public   class Announcementform: BaseEntity
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int NID { get; set; }

        /// <summary>
        /// 发布内容
        /// </summary>
        public string ReleaseContent { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// 发布人员
        /// </summary>
        public string ReleasePeople { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime ReleaseTime { get; set; }

        /// <summary>
        /// 读取状态
        /// </summary>
        public int ReadStatus { get; set; }
    }
}
